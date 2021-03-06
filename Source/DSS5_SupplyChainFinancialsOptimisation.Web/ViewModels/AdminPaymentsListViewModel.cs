// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.AdminPaymentsList;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPageForLists;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPageForLists;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList
{
    public class AdminPaymentsListViewModel : MasterPageForListsViewModel
    {
        public List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>> TransactionListNoDTSelectedItems;


        public AdminPaymentsListViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList.AdminPaymentsListViewModel))]
    public class AdminPaymentsListViewModelDTO : MasterPageForListsViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList.AdminPaymentsListViewModel>
    {

        [JsonConstructor]
        public AdminPaymentsListViewModelDTO() { }
        public AdminPaymentsListViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList.AdminPaymentsListViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            TransactionListNoDTSelectedItemKeys = original.TransactionListNoDTSelectedItems == null
                                                  ? null
                                                  : original.TransactionListNoDTSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList.AdminPaymentsListViewModel).FullName;
        public List<SelectedItemInfo<int?>> TransactionListNoDTSelectedItemKeys;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList.AdminPaymentsListViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList.AdminPaymentsListViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList.AdminPaymentsListViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList.AdminPaymentsListViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList.AdminPaymentsListViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.AdminPaymentsList.AdminPaymentsListViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.TransactionListNoDTSelectedItems = TransactionListNoDTSelectedItemKeys == null
                    ? new List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>>()
                    : TransactionListNoDTSelectedItemKeys.Select(x => new SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(x.SelectedItems.Select(y => ViewModels.AdminPaymentsList.TransactionDataSet_TransactionDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction))]
    [DataSetDTO]
    public class TransactionDataSet_TransactionDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public DateTime? TransactionDateOccured;
        public decimal? TransactionValue;
        public decimal? FundedAmount;
        public decimal? ToBePaidAmount;
        public string PaymentStatus;
        public DateTime? PaymentDate;
        public decimal? RestPaymentAmount;
        public bool PaidByBuyer;


        [JsonConstructor]
        public TransactionDataSet_TransactionDTO() : base() {}
        public  static TransactionDataSet_TransactionDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new AdminPaymentsListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new TransactionDataSet_TransactionDTO(foundEntry);
            }
            return null;
        }
        public TransactionDataSet_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public TransactionDataSet_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.Id == 0) ? original._GetUniqueIdentifier() as object : original.Id as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            Id = original.Id;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            TransactionDateOccured = original.TransactionDateOccured;
            TransactionValue = original.TransactionValue;
            FundedAmount = original.FundedAmount;
            ToBePaidAmount = original.ToBePaidAmount;
            PaymentStatus = original.PaymentStatus;
            PaymentDate = original.PaymentDate;
            RestPaymentAmount = original.RestPaymentAmount;
            PaidByBuyer = original.PaidByBuyer;
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.Transaction GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.Transaction Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.Transaction();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.TransactionDateOccured = TransactionDateOccured;
            model.TransactionValue = TransactionValue;
            model.FundedAmount = FundedAmount;
            model.ToBePaidAmount = ToBePaidAmount;
            model.PaymentStatus = PaymentStatus;
            model.PaymentDate = PaymentDate;
            model.RestPaymentAmount = RestPaymentAmount;
            model.PaidByBuyer = PaidByBuyer;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    #endregion

}
