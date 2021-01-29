// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var directiveScopeReadyLimit = 10;
var directiveScopeReadyTimeout = 200;
window.onbeforeunload = (e) => {
    if (window._context.isDirty) {
        var msg = window._resourcesManager.getGlobalResource("RES_WEBFORM_DirtyMessage");
        e.returnValue = msg;     // Gecko, Trident, Chrome 34+
        return msg;
    }
};
interface Window { scope_InvoiceList: DSS5_SupplyChainFinancialsOptimisation.Controllers.IInvoiceListScope; }
namespace DSS5_SupplyChainFinancialsOptimisation.Controllers {
const InvoiceListConditionalFormattings = [
        ];
export var InvoiceList_InvoiceListNoDT_ConditionalFormattings = {
ApplyCSSToCellConditional:
    {
'forRow':
        {

        },
'forColumns':
        {
'TotalPrice':
            { 'whenTrue': ['ApplyCssClass|align-text-cent'] }
        }
    },
};
const InvoiceListDataValidations = [
                                   ];
const InvoiceListCalculatedExpressions = [
        ];

// Datasets Column Info
var InvoiceListNoDT_ColumnInfo = [
new Joove.Widgets.DataListColumnInfo({
dataType: "int",
dataTypeIsEnum: false,
name: "Transaction.Id",
caption: window._resourcesManager.getDataListColumnCaption("InvoiceListNoDT", "Transaction.Id", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "InvoiceNumber",
caption: window._resourcesManager.getDataListColumnCaption("InvoiceListNoDT", "InvoiceNumber", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 100,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "string",
dataTypeIsEnum: false,
name: "Description",
caption: window._resourcesManager.getDataListColumnCaption("InvoiceListNoDT", "Description", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
    length: 100,
formatting: null,
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "DateTime",
dataTypeIsEnum: false,
name: "DateIssued",
caption: window._resourcesManager.getDataListColumnCaption("InvoiceListNoDT", "DateIssued", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: { 'dateFormat': 'DD/MM/YYYY', 'backEndFormatting': 'dd/MM/yyyy' , 'excelFormat': 'dd/MM/yyyy' },
width: null,
css: "",
isEncrypted: false,
showFullImage: false
}),

new Joove.Widgets.DataListColumnInfo({
dataType: "decimal",
dataTypeIsEnum: false,
name: "TotalPrice",
caption: window._resourcesManager.getDataListColumnCaption("InvoiceListNoDT", "TotalPrice", false),
groupable: true,
searchable: true,
visible: true,
orderable: true,
editable: false,
style: "",
classes: "",
itemType: Joove.Widgets.DataListColumnItemType.TEXTBOX,
importable: false,
supportsAggregators: true,
length: null,
formatting: { 'decimals': 2, 'groups': true, 'signed': false, 'showOnlyDecimalPart': false, 'dateFormat': '', 'backEndFormatting': '#,0.00;\'-\'#,0.00;\'0\'' , 'excelFormat': '#,##0.00;-#,##0.00;#,##0.00'},
width: null,
css: "",
isEncrypted: false,
showFullImage: false
})] as any;
window["InvoiceListNoDT_ColumnInfo"] = InvoiceListNoDT_ColumnInfo;

// Datasets Projection Shemas
window["InvoiceListNoDT_ProjectionScema"] = {};


export interface IInvoiceListScope extends Joove.IWebPageScope {
model:
    DSS5_SupplyChainFinancialsOptimisation.ViewModels.InvoiceList.InvoiceListViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class InvoiceListController {
private timeoutDelayLockModifyClicked:
    any;
private timeoutDelayLockDeleteClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_InvoiceList.model = window.scope_InvoiceList.dehydrate();
        //window.scope_MasterPageForLists.model = window.scope_InvoiceList.model;
        DSS5_SupplyChainFinancialsOptimisation.ViewModels.InvoiceList.InvoiceListViewModel._lightCast(window.scope_InvoiceList.model);
        // Joove.Common.applyScope(window.scope_InvoiceList);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IInvoiceListScope, $timeout: ng.ITimeoutService) {
        window.scope_InvoiceList = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS5_SupplyChainFinancialsOptimisation.ViewModels.InvoiceList.InvoiceListViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPageForLists._validations;
        $scope._validations = { summary:
                                [],
                              };

        this.init($scope, $timeout);
        $timeout(() => {

            window._ruleEngine.update(Joove.EvaluationTimes.OnLoad, null, () => {

                $("body").fadeIn(200);

            });
        });

    }

    init($scope: IInvoiceListScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.InvoiceList.InvoiceListViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPageForLists.model = $scope.model;

        new Joove.ReferencesReconstructor().reconstructReferences($scope.model);
        $scope.trackObject = obj => Joove.Common.trackObject(obj);


        //}

        $.connection['eventsHub'].on('__connectedEvent');

        $.connection['eventsHub'].on('forcePageReload', () => {
            window.onbeforeunload = null;
            setTimeout(() => {
                window.location.reload();
            }, 3000);
        });
        $.connection.hub.start(() => {
            Joove.Common.getScope().connectedToSignals();
            Joove.Common.getMasterScope().connectedToSignals();

        });
        $scope.connectedToSignals = () => {
        }
// Event Listeners
        $scope.events = {
        };
        $scope.expressions = {
        }
// Dataset Handler
        $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
Retrieve:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("InvoiceList", "Retrieve", "GET", [], {}, _modalOptions);
            },
DeleteSeclected:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();
                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                window._context.isDirty = false;
                Joove.Core.executeControllerActionNew({
verb: 'POST', controller: 'InvoiceList', action: 'DeleteSeclected',
queryData: [], postData: {'model': $scope.model},
cb: _cb, modalOptions: _modalOptions, event: _e
                });
            },
        };
// Events
        $scope.eventCallbacks = {
ModifyClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockModifyClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockModifyClicked);
                }

                this.timeoutDelayLockModifyClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        //This is true only when the menu item is clicked programmatically
                        //and occurs when the middle mouse button click is triggered
                        var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                        if (openInNewWindow) $(e.target).data("openInNewWindow", undefined); Joove.Core.executeRedirectControllerAction("InvoiceForm", "EditInvoice", "GET", [Joove.Common.nullSafe<any>(() => Joove.DatasourceManager.getSelectedItem($("[jb-id='InvoiceListNoDT']"), e).Id, 0)], null, null, openInNewWindow);
}, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

DeleteClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockDeleteClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockDeleteClicked);
                }

                this.timeoutDelayLockDeleteClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);
                    window._popUpManager.question(window._resourcesManager.getGlobalResource("RES_WEBFORM_GenericConfirmationQuestion"),
                    window._resourcesManager.getEventConfirmation("Delete", false), (isConfirm) => {
                        if (!isConfirm) return;

                        setTimeout(() => {

                            Joove.Validation.Manager.validateFormAndExecute(() => {
                                $scope.actions.DeleteSeclected(null, null, e);
}, { groups: [Joove.Validation.Constants.ALL_GROUPS], withDataValidationsCheck: true, withRequiredFieldsCheck: true });
                        }, 1000);
                    });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(InvoiceListDataValidations);
        window._ruleEngine.addConditionalFormattings(InvoiceListConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(InvoiceListCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPageForLists as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("InvoiceListController", ["$scope", "$timeout", InvoiceListController] as Array<string>);
}