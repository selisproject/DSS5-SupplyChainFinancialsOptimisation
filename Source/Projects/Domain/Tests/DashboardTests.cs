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
    ///This is a test class for DashboardTest and is intended
    ///to contain all DashboardTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Dashboard Repository Tests")]
    [Category("Dashboard Repository Tests")]
    internal class DashboardTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Dashboard`")]
        [Order(0)]
        public void Dashboard_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _dashboard_supplierstatistics_dashboard = new DSS5_SupplyChainFinancialsOptimisation.BO.SupplierStatistic
            {
                TotalCommercialAgreements = 1260,
                DataQuality = 222222.22M,
                DataAvailability = 5645,
                OnTimeDeliveries = 6781,
                AsOrderedDeliveries = 4605,
                InFullDeliveries = 8493,
                TotalImpeachments = 987,
                CurrentTurnover = 222222.22M,
                NextTurnover = 222222.22M,
                PreviousTurnover = 222222.22M,
                TotalTransactions = 7577,
            };
            var _dashboard_supplierstatistics_dashboard2 = new DSS5_SupplyChainFinancialsOptimisation.BO.SupplierStatistic
            {
                TotalCommercialAgreements = 7297,
                DataQuality = 222222.22M,
                DataAvailability = 5038,
                OnTimeDeliveries = 5309,
                AsOrderedDeliveries = 2321,
                InFullDeliveries = 7733,
                TotalImpeachments = 8072,
                CurrentTurnover = 222222.22M,
                NextTurnover = 222222.22M,
                PreviousTurnover = 222222.22M,
                TotalTransactions = 201,
            };
            var _dashboard_buyerstatistics_dashboard = new DSS5_SupplyChainFinancialsOptimisation.BO.BuyerStatistic
            {
            };
            var _dashboard_buyerstatistics_dashboard2 = new DSS5_SupplyChainFinancialsOptimisation.BO.BuyerStatistic
            {
            };
            new PersistenceSpecification<DSS5_SupplyChainFinancialsOptimisation.BO.Dashboard>(Session)
            .CheckBag(p => p.SupplierStatistics, (new List<DSS5_SupplyChainFinancialsOptimisation.BO.SupplierStatistic>
            {
                _dashboard_supplierstatistics_dashboard,
                _dashboard_supplierstatistics_dashboard2
            }))
            .CheckBag(p => p.BuyerStatistics, (new List<DSS5_SupplyChainFinancialsOptimisation.BO.BuyerStatistic>
            {
                _dashboard_buyerstatistics_dashboard,
                _dashboard_buyerstatistics_dashboard2
            }))
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Dashboard`")]
        [Order(1)]
        public void Dashboard_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS5_SupplyChainFinancialsOptimisation.BO.Dashboard> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Dashboard>(
                              a => true
                              && a.SupplierStatistics.Any()
                              && a.BuyerStatistics.Any()
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