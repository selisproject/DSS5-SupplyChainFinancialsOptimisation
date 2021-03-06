// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.SignUp;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.MasterPage;
using DSS5_SupplyChainFinancialsOptimisation.UI.Controllers.MasterPage;
namespace DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp
{
    public class SignUpViewModel : MasterPageViewModel
    {
        public string RetypePass;
        public string UserNameTextBox;
        public string PasswordTextBox;
        public string ChoosenRole;
        public string CompanyName;
        public string UserName;
        public string Email;
        public DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary Intermediary;
        public bool IsIntermediary;
        public List<SelectedItemInfo<string>> txtChoosenRoleSelectedItems;


        public SignUpViewModel()
        {
            Intermediary = new DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (manager.Session.Contains(Intermediary))
            {
                manager.Session.Evict(Intermediary);
            }
        }

    }


    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp.SignUpViewModel))]
    public class SignUpViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp.SignUpViewModel>
    {

        [JsonConstructor]
        public SignUpViewModelDTO() { }
        public SignUpViewModelDTO(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp.SignUpViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            RetypePass = original.RetypePass;
            UserNameTextBox = original.UserNameTextBox;
            PasswordTextBox = original.PasswordTextBox;
            ChoosenRole = original.ChoosenRole;
            CompanyName = original.CompanyName;
            UserName = original.UserName;
            Email = original.Email;
            Intermediary = original.Intermediary == null ? null : new Intermediary_IntermediaryDTO(original.Intermediary);
            IsIntermediary = original.IsIntermediary;
            txtChoosenRoleSelectedItemKeys = original.txtChoosenRoleSelectedItems == null
                                             ? null
                                             : original.txtChoosenRoleSelectedItems.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public string RetypePass;
        public string UserNameTextBox;
        public string PasswordTextBox;
        public string ChoosenRole;
        public string CompanyName;
        public string UserName;
        public string Email;
        public Intermediary_IntermediaryDTO Intermediary;
        public bool IsIntermediary;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp.SignUpViewModel).FullName;
        public List<SelectedItemInfo<string>> txtChoosenRoleSelectedItemKeys;

        public new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp.SignUpViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp.SignUpViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp.SignUpViewModel();
        }
        new  public DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp.SignUpViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp.SignUpViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.UI.ViewModels.SignUp.SignUpViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.RetypePass = RetypePass;
            original.UserNameTextBox = UserNameTextBox;
            original.PasswordTextBox = PasswordTextBox;
            original.ChoosenRole = ChoosenRole;
            original.CompanyName = CompanyName;
            original.UserName = UserName;
            original.Email = Email;
            original.Intermediary = Intermediary == null
                                    ? null
                                    : Intermediary.Convert();
            original.IsIntermediary = IsIntermediary;
            original.txtChoosenRoleSelectedItems = txtChoosenRoleSelectedItemKeys == null
                                                   ? new List<SelectedItemInfo<string>>()
                                                   : txtChoosenRoleSelectedItemKeys.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary))]
    public class Intermediary_IntermediaryDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>
    {

        [JsonConstructor]
        public Intermediary_IntermediaryDTO() { }
        public Intermediary_IntermediaryDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Company = original.Company;
            EMail = original.EMail;
            GUID = original.GUID;
            Id = original.Id;
            IntermediaryType = original.IntermediaryType;
            OtherDescription = original.OtherDescription;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public string Company;
        public string EMail;
        public string GUID;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.IntermediaryType? IntermediaryType;
        public string OtherDescription;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary).FullName;
        public override List<string> _baseClasses => null;
        public DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary();
            }
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary original)
        {
            if (original == null) return;
            original.Company = Company;
            original.EMail = EMail;
            original.GUID = GUID;
            original.Id = Id ?? 0;
            original.IntermediaryType = IntermediaryType;
            original.OtherDescription = OtherDescription;
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static Intermediary_IntermediaryDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>(parsedKey, true);
            if(foundEntry != null)
            {
                return new Intermediary_IntermediaryDTO(foundEntry);
            }
            return null;
        }
    }


    #region Datasource DTOs

    [OriginalType(typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary))]
    [DataSetDTO]
    public class IntermediaryDataSet_IntermediaryDTO : ViewModelDTOBase, IViewModelDTO<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>
    {
        public override string _originalTypeClassName => typeof(DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }


        [JsonConstructor]
        public IntermediaryDataSet_IntermediaryDTO() : base() {}
        public  static IntermediaryDataSet_IntermediaryDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new SignUpController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new IntermediaryDataSet_IntermediaryDTO(foundEntry);
            }
            return null;
        }
        public IntermediaryDataSet_IntermediaryDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public IntermediaryDataSet_IntermediaryDTO(DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary original)
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

        public static DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>(parsedKey, false);
        }
        public DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary Convert()
        {
            var model = new DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<DSS5_SupplyChainFinancialsOptimisation.BO.Intermediary>(parsedKey, false) ?? model;
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
