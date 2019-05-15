﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Reflection;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.ComponentModel.Design;
using System.Collections.Generic;
using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NuGet.Jobs;

namespace NuGet.Services.DatabaseMigration
{
    public class Job : JsonConfigurationJob
    {
        public int ExitCode { get; set; }

        private const string MigrationTargetDatabaseArgument = "MigrationTargetDatabase";
        private string _migrationTargetDatabase;
        private IMigrationContextFactory _migrationContextFactory;

        public Job(IMigrationContextFactory migrationContextFactory)
        {
            _migrationContextFactory = migrationContextFactory;
        }

        public override void Init(IServiceContainer serviceContainer, IDictionary<string, string> jobArgsDictionary)
        {
            try
            {
                base.Init(serviceContainer, jobArgsDictionary);
                _migrationTargetDatabase = JobConfigurationManager.GetArgument(jobArgsDictionary, MigrationTargetDatabaseArgument);
            } catch (Exception)
            {
                ExitCode = 1;
                throw;
            }
        }

        public override async Task Run()
        {
            Logger.LogInformation("Initializing database migration context...");

            IMigrationContext migrationContext = null;
            try
            {
                migrationContext = await _migrationContextFactory.CreateMigrationContextAsync(_migrationTargetDatabase, _serviceProvider);

                ExecuteDatabaseMigration(migrationContext.GetDbMigrator,
                    migrationContext.SqlConnection,
                    migrationContext.SqlConnectionAccessToken);
            }
            catch (Exception)
            {
                ExitCode = 1;
                throw;
            }
            finally
            {
                migrationContext?.SqlConnection?.Dispose();
            }
        }

        private void ExecuteDatabaseMigration(Func<DbMigrator> getMigrator, SqlConnection sqlConnection, string accessToken)
        {
            var migrator = getMigrator();
            var migratorForScripting = getMigrator();

            OverwriteSqlConnection(migrator, sqlConnection, accessToken);
            OverwriteSqlConnection(migratorForScripting, sqlConnection, accessToken);

            var sqlConnectionDataSource = sqlConnection.DataSource;
            var sqlConnectionDatabase = sqlConnection.Database;

            Logger.LogInformation("Target database is: {DataSource}/{Database}", sqlConnectionDataSource, sqlConnectionDatabase);
            var pendingMigrations = migrator.GetPendingMigrations();
            if (pendingMigrations.Count() > 0)
            {
                Logger.LogInformation("Applying pending migrations: \n {PendingMigrations}", String.Join("\n", pendingMigrations));

                var migratorScripter = new MigratorScriptingDecorator(migratorForScripting);
                var migrationScripts = migratorScripter.ScriptUpdate(sourceMigration: null, targetMigration: null);
                Logger.LogInformation("Applying explicit migration SQL scripts: \n {migrationScripts}", migrationScripts);

                try
                {
                    Logger.LogInformation("Executing migrations...");

                    migrator.Update();

                    Logger.LogInformation("Finished executing {pendingMigrationsCount} migrations successfully on the target database {DataSource}/{Database}",
                        pendingMigrations.Count(),
                        sqlConnectionDataSource,
                        sqlConnectionDatabase);
                }
                catch (Exception e)
                {
                    Logger.LogError(0, e, "Failed to execute migrations on the target database {DataSource}/{Database}",
                        sqlConnectionDataSource,
                        sqlConnectionDatabase);
                    throw;
                }
            }
            else
            {
                Logger.LogInformation("There are no pending migrations to execute.");
            }
        }

        // Overwrite the database connection of DbMigrator.
        // Hit the bug:  https://github.com/aspnet/EntityFramework6/issues/522
        // Consider deleting/updating this section when the new Entity Framework 6.3 or higher version is released.
        private void OverwriteSqlConnection(DbMigrator migrator, SqlConnection sqlConnection, string accessToken)
        {
            var historyRepository = typeof(DbMigrator).GetField(
                "_historyRepository",
                BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(migrator);

            var connectionField = historyRepository.GetType().BaseType.GetField(
                "_existingConnection",
                BindingFlags.NonPublic | BindingFlags.Instance);

            sqlConnection.AccessToken = accessToken;
            connectionField.SetValue(historyRepository, sqlConnection);
        }

        protected override void ConfigureAutofacServices(ContainerBuilder containerBuilder)
        {
        }

        protected override void ConfigureJobServices(IServiceCollection services, IConfigurationRoot configurationRoot)
        {
        }
    }
}

