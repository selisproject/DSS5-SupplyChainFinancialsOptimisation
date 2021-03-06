var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DSS5_SupplyChainFinancialsOptimisation;
(function (DSS5_SupplyChainFinancialsOptimisation) {
    var ViewModels;
    (function (ViewModels) {
        var TurnoverPerMonthForm;
        (function (TurnoverPerMonthForm) {
            var TurnoverPerMonthFormViewModel = (function (_super) {
                __extends(TurnoverPerMonthFormViewModel, _super);
                function TurnoverPerMonthFormViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Year: true, Supplier: true
                        };
                    }
                    else {
                        _this._members["Year"] = true;
                        _this._members["Supplier"] = true;
                    }
                    return _this;
                }
                TurnoverPerMonthFormViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    if (instance.Supplier != null)
                        instance.Supplier = Supplier_SupplierViewModel._lightCast(instance.Supplier);
                    return instance;
                };
                TurnoverPerMonthFormViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new TurnoverPerMonthFormViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateTurnoverPerMonthFormViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                TurnoverPerMonthFormViewModel.prototype._hydrateTurnoverPerMonthFormViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original.Year !== undefined)
                        this.Year = original.Year;
                    if (original.Supplier !== undefined)
                        this.Supplier = Supplier_SupplierViewModel._initializeFrom(original.Supplier, ignoreReadOnlyProperties, context);
                    this.ChartSelectedItemKeys = original.ChartSelectedItemKeys;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = TurnoverPerMonthFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        TurnoverPerMonthFormViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                TurnoverPerMonthFormViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = TurnoverPerMonthFormViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    TurnoverPerMonthFormViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                TurnoverPerMonthFormViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                TurnoverPerMonthFormViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return TurnoverPerMonthFormViewModel;
            }(DSS5_SupplyChainFinancialsOptimisation.ViewModels.MasterPage.MasterPageViewModel));
            TurnoverPerMonthForm.TurnoverPerMonthFormViewModel = TurnoverPerMonthFormViewModel;
            var Supplier_SupplierViewModel = (function (_super) {
                __extends(Supplier_SupplierViewModel, _super);
                function Supplier_SupplierViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            Company: true, UserName: true
                        };
                    }
                    else {
                        _this._members["Company"] = true;
                        _this._members["UserName"] = true;
                    }
                    return _this;
                }
                Supplier_SupplierViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                Supplier_SupplierViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new Supplier_SupplierViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateSupplier_SupplierViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                Supplier_SupplierViewModel.prototype._hydrateSupplier_SupplierViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original.Company !== undefined)
                        this.Company = original.Company;
                    if (original.UserName !== undefined)
                        this.UserName = original.UserName;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = Supplier_SupplierViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                Supplier_SupplierViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = Supplier_SupplierViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    return reduced;
                };
                Supplier_SupplierViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return Supplier_SupplierViewModel;
            }(BaseClass.ViewModel));
            TurnoverPerMonthForm.Supplier_SupplierViewModel = Supplier_SupplierViewModel;
        })(TurnoverPerMonthForm = ViewModels.TurnoverPerMonthForm || (ViewModels.TurnoverPerMonthForm = {}));
    })(ViewModels = DSS5_SupplyChainFinancialsOptimisation.ViewModels || (DSS5_SupplyChainFinancialsOptimisation.ViewModels = {}));
})(DSS5_SupplyChainFinancialsOptimisation || (DSS5_SupplyChainFinancialsOptimisation = {}));
