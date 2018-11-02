﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Net;
using Xunit;
using Xunit.Abstractions;

namespace NuGetGallery.FunctionalTests
{
    /// <summary>
    /// Base class for all the gallery test classes.
    /// Has the common functions which individual test classes would use.
    /// </summary>
    public abstract class GalleryTestBase
    {
        protected GalleryTestBase(ITestOutputHelper testOutputHelper)
        {
            TestOutputHelper = testOutputHelper;

            // suppress SSL validation for *.cloudapp.net
            ServicePointManagerInitializer.InitializeServerCertificateValidationCallback();
        }

        public ITestOutputHelper TestOutputHelper { get; private set; }
    }
}