
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
	/// The CreditNote extensions
	/// </summary>
	public static class CreditNoteExtensions
	{
        public static System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.CreditNote> FindCreditNote(){using (new zAppDev.DotNet.Framework.Profiling.Profiler("CreditNote", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "FindCreditNote")) {
string userName = "";
System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement> agreements = new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement>((a) => a.Investor.UserName == zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentApplicationUser().UserName);
System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.CreditNote> foundNotes = new System.Collections.Generic.List<DSS5_SupplyChainFinancialsOptimisation.BO.CreditNote>();
foreach (var agr in agreements ?? Enumerable.Empty<DSS5_SupplyChainFinancialsOptimisation.BO.Agreement>()) {
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "CreditNote",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "-------2-------");
userName = (agr?.Supplier?.UserName ?? "");foreach (var creditNote in new DSS5_SupplyChainFinancialsOptimisation.DAL.Repository().Get<DSS5_SupplyChainFinancialsOptimisation.BO.CreditNote>((o) => o.Transaction.Supplier.UserName == userName) ?? Enumerable.Empty<DSS5_SupplyChainFinancialsOptimisation.BO.CreditNote>()) {
foundNotes?.Add(creditNote);
zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "CreditNote",  DSS5_SupplyChainFinancialsOptimisation.Hubs.EventsHub.RaiseDebugMessage, "length foundOrders: " + (foundNotes?.Count().ToString() ?? ""));
}
}
return foundNotes;
}
}



        
	}
}