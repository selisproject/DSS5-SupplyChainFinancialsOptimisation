
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;

using DSS5_SupplyChainFinancialsOptimisation.DAL;

namespace DSS5_SupplyChainFinancialsOptimisation.BO
{
	/// <summary>
	/// The Transaction extensions
	/// </summary>
	public static class TransactionExtensions
	{
        public static void CalculateDataAvailability(this BO.Transaction @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Transaction", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "CalculateDataAvailability")) {
if ((@this?.Orders?.Count() ?? 0) > 0) {
@this.Supplier.DataAvailability.Orders = true;}
}
}


public static decimal? Get_TransactionValue(this BO.Transaction @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Transaction", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Get_TransactionValue")) {
return (@this?.Invoices?.Count() ?? 0) > 0 ? (@this?.Invoices?.Sum((a) => a.TotalPrice) ?? 0) : 0;
}
}


public static decimal? Get_FundedAmount(this BO.Transaction @this){using (new zAppDev.DotNet.Framework.Profiling.Profiler("Transaction", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Get_FundedAmount")) {
decimal? totalInv = 0;
decimal? total = 0;
totalInv = (@this?.Invoices?.Sum((a) => a.TotalPrice) ?? 0);total = (totalInv.GetValueOrDefault(0) * (@this?.CommercialAgreement?.Agreement?.FundedRate ?? 0)) / 100;return (@this?.Invoices?.Count() ?? 0) > 0 ? total : 0;
}
}



        
	}
}