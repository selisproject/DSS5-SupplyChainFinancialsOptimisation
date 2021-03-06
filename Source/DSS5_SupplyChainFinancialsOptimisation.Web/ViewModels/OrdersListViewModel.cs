// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.OrdersList;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPageForLists;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPageForLists;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList
{
    public class OrdersListViewModel : MasterPageForListsViewModel
    {
        public List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Order>> OrderListNoDTSelectedItems;


        public OrdersListViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList.OrdersListViewModel))]
    public class OrdersListViewModelDTO : MasterPageForListsViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList.OrdersListViewModel>
    {

        [JsonConstructor]
        public OrdersListViewModelDTO() { }
        public OrdersListViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList.OrdersListViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            OrderListNoDTSelectedItemKeys = original.OrderListNoDTSelectedItems == null
                                            ? null
                                            : original.OrderListNoDTSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList.OrdersListViewModel).FullName;
        public List<SelectedItemInfo<int?>> OrderListNoDTSelectedItemKeys;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList.OrdersListViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList.OrdersListViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList.OrdersListViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList.OrdersListViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList.OrdersListViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.OrdersList.OrdersListViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.OrderListNoDTSelectedItems = OrderListNoDTSelectedItemKeys == null
                                                  ? new List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Order>>()
                                                  : OrderListNoDTSelectedItemKeys.Select(x => new SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(x.SelectedItems.Select(y => ViewModels.OrdersList.OrderDataSet_OrderDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Order))]
    [DataSetDTO]
    public class OrderDataSet_OrderDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Order>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Order).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public OrderDataSet_TransactionDTO Transaction;
        public string OrderNumber;
        public string PaymentTerms;
        public DateTime? DateOfOrder;
        public decimal? OrderAmount;
        public OrderDataSet_OrderStatusDTO OrderStatus;
        public decimal? TotalPrice;


        [JsonConstructor]
        public OrderDataSet_OrderDTO() : base() {}
        public  static OrderDataSet_OrderDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new OrdersListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Order>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new OrderDataSet_OrderDTO(foundEntry);
            }
            return null;
        }
        public OrderDataSet_OrderDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Order original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public OrderDataSet_OrderDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Order original)
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
            Transaction = original.Transaction == null
                          ? null
                          : DTOHelper.GetDTOFromModel<OrderDataSet_TransactionDTO>(original.Transaction as DSS5_SupplyChainFinancialsOptimisation.BO.Transaction);
            OrderNumber = original.OrderNumber;
            PaymentTerms = original.PaymentTerms;
            DateOfOrder = original.DateOfOrder;
            OrderAmount = original.OrderAmount;
            OrderStatus = original.OrderStatus == null
                          ? null
                          : DTOHelper.GetDTOFromModel<OrderDataSet_OrderStatusDTO>(original.OrderStatus as DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus);
            TotalPrice = original.TotalPrice;
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.Order GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.Order Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.Order();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Transaction = Transaction == null
                                ? null
                                : DTOHelper.GetModelFromDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(Transaction);
            model.OrderNumber = OrderNumber;
            model.PaymentTerms = PaymentTerms;
            model.DateOfOrder = DateOfOrder;
            model.OrderAmount = OrderAmount;
            model.OrderStatus = OrderStatus == null
                                ? null
                                : DTOHelper.GetModelFromDTO<DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus>(OrderStatus);
            model.TotalPrice = TotalPrice;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction))]
    [DataSetDTO]
    public class OrderDataSet_TransactionDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>
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
        public OrderDataSet_ImportedBuyerDTO ImportedBuyer;


        [JsonConstructor]
        public OrderDataSet_TransactionDTO() : base() {}
        public  static OrderDataSet_TransactionDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new OrdersListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Transaction>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new OrderDataSet_TransactionDTO(foundEntry);
            }
            return null;
        }
        public OrderDataSet_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public OrderDataSet_TransactionDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Transaction original)
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
            ImportedBuyer = original.ImportedBuyer == null
                            ? null
                            : DTOHelper.GetDTOFromModel<OrderDataSet_ImportedBuyerDTO>(original.ImportedBuyer as DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer);
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
            model.ImportedBuyer = ImportedBuyer == null
                                  ? null
                                  : DTOHelper.GetModelFromDTO<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(ImportedBuyer);
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer))]
    [DataSetDTO]
    public class OrderDataSet_ImportedBuyerDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string Company;


        [JsonConstructor]
        public OrderDataSet_ImportedBuyerDTO() : base() {}
        public  static OrderDataSet_ImportedBuyerDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new OrdersListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new OrderDataSet_ImportedBuyerDTO(foundEntry);
            }
            return null;
        }
        public OrderDataSet_ImportedBuyerDTO(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public OrderDataSet_ImportedBuyerDTO(DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer original)
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
            Company = original.Company;
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.ImportedBuyer>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Company = Company;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus))]
    [DataSetDTO]
    public class OrderDataSet_OrderStatusDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string Status;


        [JsonConstructor]
        public OrderDataSet_OrderStatusDTO() : base() {}
        public  static OrderDataSet_OrderStatusDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new OrdersListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new OrderDataSet_OrderStatusDTO(foundEntry);
            }
            return null;
        }
        public OrderDataSet_OrderStatusDTO(DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public OrderDataSet_OrderStatusDTO(DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus original)
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
            Status = original.Status;
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.OrderStatus>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Status = Status;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement))]
    [DataSetDTO]
    public class CommercialAgreementDataSet_CommercialAgreementDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }


        [JsonConstructor]
        public CommercialAgreementDataSet_CommercialAgreementDTO() : base() {}
        public  static CommercialAgreementDataSet_CommercialAgreementDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new OrdersListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new CommercialAgreementDataSet_CommercialAgreementDTO(foundEntry);
            }
            return null;
        }
        public CommercialAgreementDataSet_CommercialAgreementDTO(DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public CommercialAgreementDataSet_CommercialAgreementDTO(DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement original)
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
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.CommercialAgreement>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    #endregion

}
