// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.ViewModels.DeveloperTools {
export class DeveloperToolsViewModel extends DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
LekosPath:
true,Supplier:
true,Buyer:
                true
            }
        } else {
            this._members["LekosPath"] = true;
            this._members["Supplier"] = true;
            this._members["Buyer"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: DeveloperToolsViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): DeveloperToolsViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        DeveloperToolsViewModel = new DeveloperToolsViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateDeveloperToolsViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateDeveloperToolsViewModel(original: DeveloperToolsViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if(original.LekosPath !== undefined) this.LekosPath = original.LekosPath;
        if(original.Supplier !== undefined) this.Supplier = original.Supplier;
        if(original.Buyer !== undefined) this.Buyer = original.Buyer;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = DeveloperToolsViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            DeveloperToolsViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): DeveloperToolsViewModel {
        var reduced = DeveloperToolsViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        DeveloperToolsViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: DeveloperToolsViewModel) {
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

public LekosPath:
    any;
public Supplier:
    any;
public Buyer:
    any;
}

}
