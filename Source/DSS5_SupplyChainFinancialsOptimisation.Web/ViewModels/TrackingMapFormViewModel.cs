// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.TrackingMapForm;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPageForSlide;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPageForSlide;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm
{
    public class TrackingMapFormViewModel : MasterPageForSlideViewModel
    {
        public string origin;
        public string destination;
        public DSS5_SupplyChainFinancialsOptimisation.BO.Order Order;
        public List<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint> MapPoints;
        public List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>> NewMapSelectedItems;


        public TrackingMapFormViewModel()
        {
            Order = new DSS5_SupplyChainFinancialsOptimisation.BO.Order();
            MapPoints = new List<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (manager.Session.Contains(Order))
            {
                manager.Session.Evict(Order);
            }
            if (MapPoints != null)
            {
                foreach (var item in MapPoints)
                {
                    if (manager.Session.Contains(item))
                    {
                        manager.Session.Evict(item);
                    }
                }
            }
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm.TrackingMapFormViewModel))]
    public class TrackingMapFormViewModelDTO : MasterPageForSlideViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm.TrackingMapFormViewModel>
    {

        [JsonConstructor]
        public TrackingMapFormViewModelDTO() { }
        public TrackingMapFormViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm.TrackingMapFormViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            origin = original.origin;
            destination = original.destination;
            Order = original.Order == null ? null : new Order_OrderDTO(original.Order);
            MapPoints = original.MapPoints?.Select(x => new MapPoints_MapPointDTO(x)).ToList();
            NewMapSelectedItemKeys = original.NewMapSelectedItems == null
                                     ? null
                                     : original.NewMapSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public string origin;
        public string destination;
        public Order_OrderDTO Order;
        public List<MapPoints_MapPointDTO> MapPoints;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm.TrackingMapFormViewModel).FullName;
        public List<SelectedItemInfo<int?>> NewMapSelectedItemKeys;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm.TrackingMapFormViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm.TrackingMapFormViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm.TrackingMapFormViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm.TrackingMapFormViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm.TrackingMapFormViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.TrackingMapForm.TrackingMapFormViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.origin = origin;
            original.destination = destination;
            original.Order = Order == null
                             ? null
                             : Order.Convert();
            original.MapPoints = MapPoints == null
                                 ? null
                                 : MapPoints.Select(q => q.Convert()).ToList();
            original.NewMapSelectedItems = NewMapSelectedItemKeys == null
                                           ? new List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>>()
                                           : NewMapSelectedItemKeys.Select(x => new SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>(x.SelectedItems.Select(y => ViewModels.TrackingMapForm.MapPointDataset_MapPointDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Order))]
    public class Order_OrderDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Order>
    {

        [JsonConstructor]
        public Order_OrderDTO() { }
        public Order_OrderDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Order original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            DateOfOrder = original.DateOfOrder;
            DeliveryTo = original.DeliveryTo;
            EstimatedDateOfDelivery = original.EstimatedDateOfDelivery;
            From = original.From;
            Id = original.Id;
            IntermediateParty = original.IntermediateParty;
            IsCancelled = original.IsCancelled;
            OrderAmount = original.OrderAmount;
            OrderAttachment = original.OrderAttachment;
            OrderNumber = original.OrderNumber;
            PaymentTerms = original.PaymentTerms;
            Status = original.Status;
            TotalPrice = original.TotalPrice;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public DateTime? DateOfOrder;
        public string DeliveryTo;
        public DateTime? EstimatedDateOfDelivery;
        public string From;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public bool IntermediateParty;
        public bool IsCancelled;
        public decimal? OrderAmount;
        public string OrderAttachment;
        public string OrderNumber;
        public string PaymentTerms;
        public DSS5_SupplyChainFinancialsOptimisation.BO.Status? Status;
        public decimal? TotalPrice;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Order).FullName;
        public override List<string> _baseClasses => null;
        public DSS5_SupplyChainFinancialsOptimisation.BO.Order GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.Order();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.Order Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.Order();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.Order original)
        {
            if (original == null) return;
            original.DateOfOrder = DateOfOrder;
            original.DeliveryTo = DeliveryTo;
            original.EstimatedDateOfDelivery = EstimatedDateOfDelivery;
            original.From = From;
            original.Id = Id ?? 0;
            original.IntermediateParty = IntermediateParty;
            original.IsCancelled = IsCancelled;
            original.OrderAmount = OrderAmount;
            original.OrderAttachment = OrderAttachment;
            original.OrderNumber = OrderNumber;
            original.PaymentTerms = PaymentTerms;
            original.Status = Status;
            original.TotalPrice = TotalPrice;
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static Order_OrderDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Order>(parsedKey, true);
            if(foundEntry != null)
            {
                return new Order_OrderDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint))]
    public class MapPoints_MapPointDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>
    {

        [JsonConstructor]
        public MapPoints_MapPointDTO() { }
        public MapPoints_MapPointDTO(DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Address = original.Address;
            Icon = original.Icon;
            Id = original.Id;
            Latitude = original.Latitude;
            Longitude = original.Longitude;
            Title = original.Title;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public string Address;
        public string Icon;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public double? Latitude;
        public double? Longitude;
        public string Title;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint).FullName;
        public override List<string> _baseClasses => null;
        public DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint original)
        {
            if (original == null) return;
            original.Address = Address;
            original.Icon = Icon;
            original.Id = Id ?? 0;
            original.Latitude = Latitude;
            original.Longitude = Longitude;
            original.Title = Title;
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static MapPoints_MapPointDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>(parsedKey, true);
            if(foundEntry != null)
            {
                return new MapPoints_MapPointDTO(foundEntry);
            }
            return null;
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier))]
    [DataSetDTO]
    public class SupplierDataSet_SupplierDTO : SupplierDataSet_ApplicationUserDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier).FullName;
        public new string _runtimeType;
        public string UserName;
        public new object _key
        {
            get;
            set;
        }


        [JsonConstructor]
        public SupplierDataSet_SupplierDTO() : base() {}
        public new static SupplierDataSet_SupplierDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new TrackingMapFormController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new SupplierDataSet_SupplierDTO(foundEntry);
            }
            return null;
        }
        public SupplierDataSet_SupplierDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, UserName);
        }
        public SupplierDataSet_SupplierDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Supplier original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.UserName == "") ? original._GetUniqueIdentifier() as object : original.UserName as object;
            _runtimeType = original?.GetType().FullName;
            UserName = original.UserName;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
        }

        public new static DSS5_SupplyChainFinancialsOptimisation.BO.Supplier GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = (rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(parsedKey, false);
        }
        public new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier();
            if (_key != null && _key.ToString() != "")
            {
                var rawKey = _key.ToString();
                var parsedKey = (rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Supplier>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.UserName = UserName ?? "";
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }
    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser))]
    [DataSetDTO]
    public class SupplierDataSet_ApplicationUserDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>
    {
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public string UserName;
        public new object _key
        {
            get;
            set;
        }


        [JsonConstructor]
        public SupplierDataSet_ApplicationUserDTO() : base() {}
        public  static SupplierDataSet_ApplicationUserDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new TrackingMapFormController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new SupplierDataSet_ApplicationUserDTO(foundEntry);
            }
            return null;
        }
        public SupplierDataSet_ApplicationUserDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, UserName);
        }
        public SupplierDataSet_ApplicationUserDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.UserName == "") ? original._GetUniqueIdentifier() as object : original.UserName as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            UserName = original.UserName;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
        }

        public static zAppDev.DotNet.Framework.Identity.Model.ApplicationUser GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = (rawKey);
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationUser Convert()
        {
            var model = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser();
            if (_key != null && _key.ToString() != "")
            {
                var rawKey = _key.ToString();
                var parsedKey = (rawKey);
                model = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.UserName = UserName ?? "";
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint))]
    [DataSetDTO]
    public class MapPointDataset_MapPointDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public double? Latitude;
        public double? Longitude;
        public string Title;
        public string Icon;


        [JsonConstructor]
        public MapPointDataset_MapPointDTO() : base() {}
        public  static MapPointDataset_MapPointDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new TrackingMapFormController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new MapPointDataset_MapPointDTO(foundEntry);
            }
            return null;
        }
        public MapPointDataset_MapPointDTO(DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public MapPointDataset_MapPointDTO(DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint original)
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
            Latitude = original.Latitude;
            Longitude = original.Longitude;
            Title = original.Title;
            Icon = original.Icon;
        }

        public static DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.MapPoint>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.Latitude = Latitude;
            model.Longitude = Longitude;
            model.Title = Title;
            model.Icon = Icon;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    #endregion

}
