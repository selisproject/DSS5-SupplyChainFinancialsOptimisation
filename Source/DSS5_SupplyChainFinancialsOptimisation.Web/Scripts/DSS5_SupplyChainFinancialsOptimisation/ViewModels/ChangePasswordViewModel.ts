// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.ViewModels.ChangePassword {
export class ChangePasswordViewModel extends DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel {
    public constructor() {
        super();
        this._clientPostedProps = null;
        if (this._members == null) {
            this._members = {
txtCurrent:
true,txtNew:
true,txtNewRepeat:
                true
            }
        } else {
            this._members["txtCurrent"] = true;
            this._members["txtNew"] = true;
            this._members["txtNewRepeat"] = true;
        }

    }


    public static _lightCast(instance: any): any {
        if (instance == null) return;

        return instance;
    }

    public static _initializeFrom(original: ChangePasswordViewModel, ignoreReadOnlyProperties: boolean = false, context = new Joove.DTOHelper()): ChangePasswordViewModel {
        if(original == null) return null;
        // if (context.Has(original)) {
        //    return context.Get(original);
        // }
var result:
        ChangePasswordViewModel = new ChangePasswordViewModel();
        if (context != null && context.fillDb == true) {
            context.addToDb(original);
        }
        result._hydrateChangePasswordViewModel(original, ignoreReadOnlyProperties, context);
        // context.Add(original, result);
        return result;
    }


    public _hydrateChangePasswordViewModel(original: ChangePasswordViewModel, ignoreReadOnlyProperties: boolean, context = new Joove.DTOHelper()): void {
        if(original == null) return;

        this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);

        if(original._key !== undefined) this._key = original._key;
        if(original._clientKey !== undefined) this._clientKey = original._clientKey;
        if(original._originalTypeClassName !== undefined) this._originalTypeClassName = original._originalTypeClassName;
        if(original._typeHash !== undefined) this._typeHash = original._typeHash;

        if(original.txtCurrent !== undefined) this.txtCurrent = original.txtCurrent;
        if(original.txtNew !== undefined) this.txtNew = original.txtNew;
        if(original.txtNewRepeat !== undefined) this.txtNewRepeat = original.txtNewRepeat;

        this._reduceData = function(ignoreReadOnlyProperties: boolean) {
            var reduced = ChangePasswordViewModel._initializeFrom(this, ignoreReadOnlyProperties);
            ChangePasswordViewModel._deleteDropDownInitialValues(reduced);
            return reduced;
        };
    } /* end _initializeFrom() */


    public _reduceData(ignoreReadOnlyProperties: boolean): ChangePasswordViewModel {
        var reduced = ChangePasswordViewModel._initializeFrom(this, ignoreReadOnlyProperties);
        ChangePasswordViewModel._deleteDropDownInitialValues(reduced);
        return reduced;
    }

    public static _deleteDropDownInitialValues(reduced: ChangePasswordViewModel) {
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

public txtCurrent:
    any;
public txtNew:
    any;
public txtNewRepeat:
    any;
}

}
