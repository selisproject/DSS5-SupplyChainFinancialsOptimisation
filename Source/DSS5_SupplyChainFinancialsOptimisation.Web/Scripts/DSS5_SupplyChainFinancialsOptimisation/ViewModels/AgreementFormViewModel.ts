// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.ViewModels.AgreementForm {
export class AgreementFormViewModel extends DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
Agreement:
true,ApprovedBy:
true,IsSupplier:
true,ApprovedByEverybody:
                true
            }
        } else {
            this._members["Agreement"] = true;
            this._members["ApprovedBy"] = true;
            this._members["IsSupplier"] = true;
            this._members["ApprovedByEverybody"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        if(instance.Agreement != null)
            instance.Agreement = Agreement_AgreementViewModel._lightCast(instance.Agreement);
        return instance;
    }

    public static _initializeFrom(original: AgreementFormViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): AgreementFormViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        AgreementFormViewModel = new AgreementFormViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateAgreementFormViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateAgreementFormViewModel(original: AgreementFormViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;


        if(original.Agreement !== undefined) this.Agreement = Agreement_AgreementViewModel._initializeFrom(original.Agreement, ignoreReadOnlyProperties, context);
        if(original.ApprovedBy !== undefined) this.ApprovedBy = original.ApprovedBy;
        if(original.IsSupplier !== undefined) this.IsSupplier = original.IsSupplier;
        if(original.ApprovedByEverybody !== undefined) this.ApprovedByEverybody = original.ApprovedByEverybody;
        this.PickListSelectedItemKeys = original.PickListSelectedItemKeys;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = AgreementFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            AgreementFormViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): AgreementFormViewModel {
        var reduced = AgreementFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        AgreementFormViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: AgreementFormViewModel) {
        if (reduced == null) return;


        DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public Agreement:
    any;
public ApprovedBy:
    any;
public IsSupplier:
    any;
public ApprovedByEverybody:
    any;
public PickListSelectedItemKeys:
    any[];
}

export class Agreement_AgreementViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
CurrentAgreementStatus:
true,EndDate:
true,FundedRate:
true,Id:
true,InterestRate:
true,StartDate:
true,Investor:
true,Supplier:
true,AgreementStatus:
true,DocumentAgreement:
true,CommercialAgreements:
                true
            }
        } else {
            this._members["CurrentAgreementStatus"] = true;
            this._members["EndDate"] = true;
            this._members["FundedRate"] = true;
            this._members["Id"] = true;
            this._members["InterestRate"] = true;
            this._members["StartDate"] = true;
            this._members["Investor"] = true;
            this._members["Supplier"] = true;
            this._members["AgreementStatus"] = true;
            this._members["DocumentAgreement"] = true;
            this._members["CommercialAgreements"] = true;
        }

        this.AgreementStatus = new Array<any>();
        this.CommercialAgreements = new Array<any>();
    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        if(instance.EndDate != null) instance.EndDate = new Date(instance.EndDate);
        if(instance.StartDate != null) instance.StartDate = new Date(instance.StartDate);
        if(instance.Investor != null)
            instance.Investor = Agreement_Agreement_Investor_InvestorViewModel._lightCast(instance.Investor);
        if(instance.Supplier != null)
            instance.Supplier = Agreement_Agreement_Supplier_SupplierViewModel._lightCast(instance.Supplier);

        if(instance.AgreementStatus != null) {
            for(let i = 0; i < instance.AgreementStatus.length; i++) {
                instance.AgreementStatus[i] = Agreement_Agreement_AgreementStatus_AgreementStatusViewModel._lightCast(instance.AgreementStatus[i]);

            }
        }
        if(instance.DocumentAgreement != null)
            instance.DocumentAgreement = Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel._lightCast(instance.DocumentAgreement);

        if(instance.CommercialAgreements != null) {
            for(let i = 0; i < instance.CommercialAgreements.length; i++) {
                instance.CommercialAgreements[i] = Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel._lightCast(instance.CommercialAgreements[i]);

            }
        }
        return instance;
    }

    public static _initializeFrom(original: Agreement_AgreementViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): Agreement_AgreementViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        Agreement_AgreementViewModel = new Agreement_AgreementViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateAgreement_AgreementViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateAgreement_AgreementViewModel(original: Agreement_AgreementViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if (original._versionTimestamp !== undefined) this._versionTimestamp = original._versionTimestamp;
        if(original.CurrentAgreementStatus !== undefined) this.CurrentAgreementStatus = original.CurrentAgreementStatus;
        if(!CLMS.Framework.String.IsNullOrEmpty(original.EndDate)) this.EndDate = new Date(original.EndDate);
        if(original.FundedRate !== undefined) this.FundedRate = original.FundedRate;
        if(original.Id !== undefined) this.Id = original.Id;
        if(original.InterestRate !== undefined) this.InterestRate = original.InterestRate;
        if(!CLMS.Framework.String.IsNullOrEmpty(original.StartDate)) this.StartDate = new Date(original.StartDate);

        if(original.Investor !== undefined) this.Investor = Agreement_Agreement_Investor_InvestorViewModel._initializeFrom(original.Investor, ignoreReadOnlyProperties, context);

        if(original.Supplier !== undefined) this.Supplier = Agreement_Agreement_Supplier_SupplierViewModel._initializeFrom(original.Supplier, ignoreReadOnlyProperties, context);

        if(original.AgreementStatus != null) {
            for(let i = 0; i < original.AgreementStatus.length; i++) {
                this.AgreementStatus.push(Agreement_Agreement_AgreementStatus_AgreementStatusViewModel._initializeFrom(original.AgreementStatus[i], ignoreReadOnlyProperties, context));
            }
        }

        if(original.DocumentAgreement !== undefined) this.DocumentAgreement = Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel._initializeFrom(original.DocumentAgreement, ignoreReadOnlyProperties, context);

        if(original.CommercialAgreements != null) {
            for(let i = 0; i < original.CommercialAgreements.length; i++) {
                this.CommercialAgreements.push(Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel._initializeFrom(original.CommercialAgreements[i], ignoreReadOnlyProperties, context));
            }
        }

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = Agreement_AgreementViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): Agreement_AgreementViewModel {
        var reduced = Agreement_AgreementViewModel._initializeFrom(this, ignoreReadOnlyProperties);

        return reduced;
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public CurrentAgreementStatus:
    any;
public EndDate:
    any;
public FundedRate:
    any;
public Id:
    any;
public InterestRate:
    any;
public StartDate:
    any;
public Investor:
    any;
public Supplier:
    any;
public AgreementStatus:
    Array<any>;
public DocumentAgreement:
    any;
public CommercialAgreements:
    Array<any>;
    public _versionTimestamp?: string;
}

export class Agreement_Agreement_Investor_InvestorViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
Company:
true,UserName:
                true
            }
        } else {
            this._members["Company"] = true;
            this._members["UserName"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: Agreement_Agreement_Investor_InvestorViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): Agreement_Agreement_Investor_InvestorViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        Agreement_Agreement_Investor_InvestorViewModel = new Agreement_Agreement_Investor_InvestorViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateAgreement_Agreement_Investor_InvestorViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateAgreement_Agreement_Investor_InvestorViewModel(original: Agreement_Agreement_Investor_InvestorViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if(original.Company !== undefined) this.Company = original.Company;
        if(original.UserName !== undefined) this.UserName = original.UserName;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = Agreement_Agreement_Investor_InvestorViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): Agreement_Agreement_Investor_InvestorViewModel {
        var reduced = Agreement_Agreement_Investor_InvestorViewModel._initializeFrom(this, ignoreReadOnlyProperties);

        return reduced;
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public Company:
    any;
public UserName:
    any;
}

export class Agreement_Agreement_Supplier_SupplierViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
AdditionalComments:
true,AdditionalCommentsStep2:
true,AdditionalCommentsStep3:
true,Company:
true,MarketSegment:
true,UserName:
true,VATNumber:
                true
            }
        } else {
            this._members["AdditionalComments"] = true;
            this._members["AdditionalCommentsStep2"] = true;
            this._members["AdditionalCommentsStep3"] = true;
            this._members["Company"] = true;
            this._members["MarketSegment"] = true;
            this._members["UserName"] = true;
            this._members["VATNumber"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: Agreement_Agreement_Supplier_SupplierViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): Agreement_Agreement_Supplier_SupplierViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        Agreement_Agreement_Supplier_SupplierViewModel = new Agreement_Agreement_Supplier_SupplierViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateAgreement_Agreement_Supplier_SupplierViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateAgreement_Agreement_Supplier_SupplierViewModel(original: Agreement_Agreement_Supplier_SupplierViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if(original.AdditionalComments !== undefined) this.AdditionalComments = original.AdditionalComments;
        if(original.AdditionalCommentsStep2 !== undefined) this.AdditionalCommentsStep2 = original.AdditionalCommentsStep2;
        if(original.AdditionalCommentsStep3 !== undefined) this.AdditionalCommentsStep3 = original.AdditionalCommentsStep3;
        if(original.Company !== undefined) this.Company = original.Company;
        if(original.MarketSegment !== undefined) this.MarketSegment = original.MarketSegment;
        if(original.UserName !== undefined) this.UserName = original.UserName;
        if(original.VATNumber !== undefined) this.VATNumber = original.VATNumber;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = Agreement_Agreement_Supplier_SupplierViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): Agreement_Agreement_Supplier_SupplierViewModel {
        var reduced = Agreement_Agreement_Supplier_SupplierViewModel._initializeFrom(this, ignoreReadOnlyProperties);

        return reduced;
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public AdditionalComments:
    any;
public AdditionalCommentsStep2:
    any;
public AdditionalCommentsStep3:
    any;
public Company:
    any;
public MarketSegment:
    any;
public UserName:
    any;
public VATNumber:
    any;
}

export class Agreement_Agreement_AgreementStatus_AgreementStatusViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
DateOccured:
true,Id:
true,ProvidedBy:
true,Status:
                true
            }
        } else {
            this._members["DateOccured"] = true;
            this._members["Id"] = true;
            this._members["ProvidedBy"] = true;
            this._members["Status"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        if(instance.DateOccured != null) instance.DateOccured = new Date(instance.DateOccured);
        return instance;
    }

    public static _initializeFrom(original: Agreement_Agreement_AgreementStatus_AgreementStatusViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): Agreement_Agreement_AgreementStatus_AgreementStatusViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        Agreement_Agreement_AgreementStatus_AgreementStatusViewModel = new Agreement_Agreement_AgreementStatus_AgreementStatusViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateAgreement_Agreement_AgreementStatus_AgreementStatusViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateAgreement_Agreement_AgreementStatus_AgreementStatusViewModel(original: Agreement_Agreement_AgreementStatus_AgreementStatusViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if (original._versionTimestamp !== undefined) this._versionTimestamp = original._versionTimestamp;
        if(!CLMS.Framework.String.IsNullOrEmpty(original.DateOccured)) this.DateOccured = new Date(original.DateOccured);
        if(original.Id !== undefined) this.Id = original.Id;
        if(original.ProvidedBy !== undefined) this.ProvidedBy = original.ProvidedBy;
        if(original.Status !== undefined) this.Status = original.Status;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = Agreement_Agreement_AgreementStatus_AgreementStatusViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): Agreement_Agreement_AgreementStatus_AgreementStatusViewModel {
        var reduced = Agreement_Agreement_AgreementStatus_AgreementStatusViewModel._initializeFrom(this, ignoreReadOnlyProperties);

        return reduced;
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public DateOccured:
    any;
public Id:
    any;
public ProvidedBy:
    any;
public Status:
    any;
    public _versionTimestamp?: string;
}

export class Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
AdminDocument:
true,Id:
true,InvestorDocument:
true,SupplierDocument:
                true
            }
        } else {
            this._members["AdminDocument"] = true;
            this._members["Id"] = true;
            this._members["InvestorDocument"] = true;
            this._members["SupplierDocument"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel = new Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateAgreement_Agreement_DocumentAgreement_DocumentAgreementViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateAgreement_Agreement_DocumentAgreement_DocumentAgreementViewModel(original: Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if (original._versionTimestamp !== undefined) this._versionTimestamp = original._versionTimestamp;
        if(original.AdminDocument !== undefined) this.AdminDocument = original.AdminDocument;
        if(original.Id !== undefined) this.Id = original.Id;
        if(original.InvestorDocument !== undefined) this.InvestorDocument = original.InvestorDocument;
        if(original.SupplierDocument !== undefined) this.SupplierDocument = original.SupplierDocument;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel {
        var reduced = Agreement_Agreement_DocumentAgreement_DocumentAgreementViewModel._initializeFrom(this, ignoreReadOnlyProperties);

        return reduced;
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public AdminDocument:
    any;
public Id:
    any;
public InvestorDocument:
    any;
public SupplierDocument:
    any;
    public _versionTimestamp?: string;
}

export class Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
Id:
true,PaymentTerms:
true,ImportedBuyer:
                true
            }
        } else {
            this._members["Id"] = true;
            this._members["PaymentTerms"] = true;
            this._members["ImportedBuyer"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        if(instance.ImportedBuyer != null)
            instance.ImportedBuyer = Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel._lightCast(instance.ImportedBuyer);
        return instance;
    }

    public static _initializeFrom(original: Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel = new Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateAgreement_Agreement_CommercialAgreements_CommercialAgreementViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateAgreement_Agreement_CommercialAgreements_CommercialAgreementViewModel(original: Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if (original._versionTimestamp !== undefined) this._versionTimestamp = original._versionTimestamp;
        if(original.Id !== undefined) this.Id = original.Id;
        if(original.PaymentTerms !== undefined) this.PaymentTerms = original.PaymentTerms;

        if(original.ImportedBuyer !== undefined) this.ImportedBuyer = Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel._initializeFrom(original.ImportedBuyer, ignoreReadOnlyProperties, context);

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel {
        var reduced = Agreement_Agreement_CommercialAgreements_CommercialAgreementViewModel._initializeFrom(this, ignoreReadOnlyProperties);

        return reduced;
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public Id:
    any;
public PaymentTerms:
    any;
public ImportedBuyer:
    any;
    public _versionTimestamp?: string;
}

export class Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel extends BaseClass.ViewModel  {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
Company:
true,Id:
                true
            }
        } else {
            this._members["Company"] = true;
            this._members["Id"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel = new Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateAgreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateAgreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel(original: Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;


        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if (original._versionTimestamp !== undefined) this._versionTimestamp = original._versionTimestamp;
        if(original.Company !== undefined) this.Company = original.Company;
        if(original.Id !== undefined) this.Id = original.Id;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel._initializeFrom(this, ignoreReadOnlyProperties);

            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel {
        var reduced = Agreement_Agreement_CommercialAgreements_CommercialAgreement_ImportedBuyer_ImportedBuyerViewModel._initializeFrom(this, ignoreReadOnlyProperties);

        return reduced;
    }

protected _members:
    any;
protected _clientPostedProps:
    any;

    public hasMember(propertyName: string): boolean {
        const result = this._members[propertyName];
        if (result == null) {
            return false;
        }
        return this._members[propertyName];
    }

public Company:
    any;
public Id:
    any;
    public _versionTimestamp?: string;
}

}
