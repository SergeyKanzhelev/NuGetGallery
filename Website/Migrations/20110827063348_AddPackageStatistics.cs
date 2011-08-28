using System.Data;
using Migrator.Framework;

namespace NuGetGallery {
    [Migration(20110827063348)]
    public class AddPackageStatistics : Migration {
        public override void Up() {
            Database.AddTable("PackageStatistics",
                new Column("[Key]", DbType.Int32, ColumnProperty.PrimaryKey | ColumnProperty.Identity | ColumnProperty.NotNull),
                new Column("PackageKey", DbType.Int32, ColumnProperty.NotNull),
                new Column("Timestamp", DbType.DateTime, ColumnProperty.NotNull),
                new Column("IPAddress", DbType.String, ColumnProperty.Null),
                new Column("UserAgent", DbType.String, ColumnProperty.Null)
            );

            Database.AddForeignKey("FK_PackageStatistics_Packages", "PackageStatistics", "PackageKey", "Packages", "[Key]");
        }

        public override void Down() {
            Database.RemoveTable("PackageStatistics");
        }
    }
}
