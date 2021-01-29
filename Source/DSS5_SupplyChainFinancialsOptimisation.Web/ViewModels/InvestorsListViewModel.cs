// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.InvestorsList;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPageForLists;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPageForLists;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList
{
    public class InvestorsListViewModel : MasterPageForListsViewModel
    {
        public List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Investor>> InvestorListNoDTSelectedItems;


        public InvestorsListViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList.InvestorsListViewModel))]
    public class InvestorsListViewModelDTO : MasterPageForListsViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList.InvestorsListViewModel>
    {

        [JsonConstructor]
        public InvestorsListViewModelDTO() { }
        public InvestorsListViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList.InvestorsListViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            InvestorListNoDTSelectedItemKeys = original.InvestorListNoDTSelectedItems == null
                                               ? null
                                               : original.InvestorListNoDTSelectedItems.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y.UserName).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList.InvestorsListViewModel).FullName;
        public List<SelectedItemInfo<string>> InvestorListNoDTSelectedItemKeys;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList.InvestorsListViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList.InvestorsListViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList.InvestorsListViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList.InvestorsListViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList.InvestorsListViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.InvestorsList.InvestorsListViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.InvestorListNoDTSelectedItems = InvestorListNoDTSelectedItemKeys == null
                    ? new List<SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Investor>>()
                    : InvestorListNoDTSelectedItemKeys.Select(x => new SelectedItemInfo<DSS5_SupplyChainFinancialsOptimisation.BO.Investor>(x.SelectedItems.Select(y => ViewModels.InvestorsList.InvestorDataSet_InvestorDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Investor))]
    [DataSetDTO]
    public class InvestorDataSet_InvestorDTO : InvestorDataSet_ApplicationUserDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Investor>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Investor).FullName;
        public new string _runtimeType;
        public string UserName;
        public new object _key
        {
            get;
            set;
        }
        public string Company;
        public string Email;
        public string ContactPerson;
        public string ManagingDirector;


        [JsonConstructor]
        public InvestorDataSet_InvestorDTO() : base() {}
        public new static InvestorDataSet_InvestorDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Investor>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new InvestorsListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Investor>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new InvestorDataSet_InvestorDTO(foundEntry);
            }
            return null;
        }
        public InvestorDataSet_InvestorDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Investor original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, UserName);
        }
        public InvestorDataSet_InvestorDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Investor original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.UserName == "") ? original._GetUniqueIdentifier() as object : original.UserName as object;
            _runtimeType = original?.GetType().FullName;
            UserName = original.UserName;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            Company = original.Company;
            Email = original.Email;
            ContactPerson = original.ContactPerson;
            ManagingDirector = original.ManagingDirector;
        }

        public new static DSS5_SupplyChainFinancialsOptimisation.BO.Investor GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = (rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Investor>(parsedKey, false);
        }
        public new DSS5_SupplyChainFinancialsOptimisation.BO.Investor Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.Investor();
            if (_key != null && _key.ToString() != "")
            {
                var rawKey = _key.ToString();
                var parsedKey = (rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Investor>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.UserName = UserName ?? "";
            model.Company = Company;
            model.Email = Email;
            model.ContactPerson = ContactPerson;
            model.ManagingDirector = ManagingDirector;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }
    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser))]
    [DataSetDTO]
    public class InvestorDataSet_ApplicationUserDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>
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
        public string Email;


        [JsonConstructor]
        public InvestorDataSet_ApplicationUserDTO() : base() {}
        public  static InvestorDataSet_ApplicationUserDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new InvestorsListController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new InvestorDataSet_ApplicationUserDTO(foundEntry);
            }
            return null;
        }
        public InvestorDataSet_ApplicationUserDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, UserName);
        }
        public InvestorDataSet_ApplicationUserDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original)
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
            Email = original.Email;
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
            model.Email = Email;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }


    #endregion

}