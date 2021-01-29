// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentNHibernate.Testing;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.BoTesting.Tests.Common;
using DSS5_SupplyChainFinancialsOptimisation.DAL;

namespace DSS5_SupplyChainFinancialsOptimisation.BoTesting.Tests
{
    /// <summary>
    ///This is a test class for MeanOfTransportTest and is intended
    ///to contain all MeanOfTransportTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("MeanOfTransport Repository Tests")]
    [Category("MeanOfTransport Repository Tests")]
    internal class MeanOfTransportTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `MeanOfTransport`")]
        [Order(0)]
        public void MeanOfTransport_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS5_SupplyChainFinancialsOptimisation.BO.MeanOfTransport>(Session)
            .CheckProperty(p => p.LicensePlate, "MeanOfTransport_LicensePlate")
            .CheckProperty(p => p.ContainerId, "MeanOfTransport_ContainerId")
            .CheckProperty(p => p.ShipId, "MeanOfTransport_ShipId")
            .CheckProperty(p => p.TrainId, "MeanOfTransport_TrainId")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `MeanOfTransport`")]
        [Order(1)]
        public void MeanOfTransport_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS5_SupplyChainFinancialsOptimisation.BO.MeanOfTransport> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.MeanOfTransport>(
                              a => true
                              && (a.LicensePlate != string.Empty && a.LicensePlate != null)
                              && (a.ContainerId != string.Empty && a.ContainerId != null)
                              && (a.ShipId != string.Empty && a.ShipId != null)
                              && (a.TrainId != string.Empty && a.TrainId != null)
                              ,
                              cacheQuery: true)
                          .OrderBy(a => a)
                          .Skip(0)
                          .Take(3)
                          .ToList();
            });
            Assert.AreNotEqual(null, results);
        }
    }
}