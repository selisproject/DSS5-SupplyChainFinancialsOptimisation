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
interface Window { scope_OperationsList: DSS5_SupplyChainFinancialsOptimisation.Controllers.IOperationsListScope; }
namespace DSS5_SupplyChainFinancialsOptimisation.Controllers {
const OperationsListConditionalFormattings = [
        ];
const OperationsListDataValidations = [
                                      ];
const OperationsListCalculatedExpressions = [
        ];

// Datasets Column Info
export var List1DataSet_ColumnInfo = [new Joove.ColumnInfo("ParentControllerName", "string", null, false),
                                      new Joove.ColumnInfo("Name", "string", null, false),
                                      new Joove.ColumnInfo("IsAvailableToAnonymous", "bool", null, false),
                                      new Joove.ColumnInfo("IsAvailableToAllAuthorizedUsers", "bool", null, false)];
window["List1DataSet_ColumnInfo"] = List1DataSet_ColumnInfo;

// Datasets Projection Shemas
window["Table_ProjectionScema"] = {};


export interface IOperationsListScope extends Joove.IWebPageScope {
model:
    DSS5_SupplyChainFinancialsOptimisation.ViewModels.OperationsList.OperationsListViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class OperationsListController {
private timeoutDelayLockButton11Clicked:
    any;
private timeoutDelayLockControllerClicked:
    any;
private timeoutDelayLockNameClicked:
    any;
private timeoutDelayLockName1Clicked:
    any;
private timeoutDelayLockName2Clicked:
    any;
private timeoutDelayLockButtonClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_OperationsList.model = window.scope_OperationsList.dehydrate();
        //window.scope_MasterPage.model = window.scope_OperationsList.model;
        DSS5_SupplyChainFinancialsOptimisation.ViewModels.OperationsList.OperationsListViewModel._lightCast(window.scope_OperationsList.model);
        // Joove.Common.applyScope(window.scope_OperationsList);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: IOperationsListScope, $timeout: ng.ITimeoutService) {
        window.scope_OperationsList = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS5_SupplyChainFinancialsOptimisation.ViewModels.OperationsList.OperationsListViewModel._initializeFrom($scope.model, context);
        $scope._validationsMaster =  window.scope_MasterPage._validations;
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

    init($scope: IOperationsListScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.OperationsList.OperationsListViewModel._initializeFrom(window.viewDTO.Model);

        window.scope_MasterPage.model = $scope.model;

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
Refresh:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();

                const implementation = async (): Promise<any> => {
                    Joove.Common.nullSafe<any>(() => window._commander.gridRefresh(["Table"]), null);


                    // Joove.Common.applyScope(window.scope_OperationsList);
                }

                await window._ruleEngine.update(Joove.EvaluationTimes.OnSubmit);

                let spamHelper = new Joove.SpamControlHelper(_e);
                spamHelper.Disable();
                await implementation();
                spamHelper.Enable();
                this.controllerActionFinished(true);
            },
Retrieve:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("OperationsList", "Retrieve", "GET", [], {}, _modalOptions);
            },
        };
// Events
        $scope.eventCallbacks = {
Button11Clicked:
            (e: any): any => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                Joove.DatasourceManager.clearFiltersToControlsBoundToDataSet('List1DataSet', e);
            },

ControllerClicked:
            (e: any): any => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                var $element = $(e.target);
                var targetProp = $element.attr('joove-ds-sort-OnClick');

                Joove.DatasourceManager.sortControlsBoundToDataSet('List1DataSet', targetProp, e);
            },

NameClicked:
            (e: any): any => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                var $element = $(e.target);
                var targetProp = $element.attr('joove-ds-sort-OnClick');

                Joove.DatasourceManager.sortControlsBoundToDataSet('List1DataSet', targetProp, e);
            },

Name1Clicked:
            (e: any): any => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                var $element = $(e.target);
                var targetProp = $element.attr('joove-ds-sort-OnClick');

                Joove.DatasourceManager.sortControlsBoundToDataSet('List1DataSet', targetProp, e);
            },

Name2Clicked:
            (e: any): any => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                var $element = $(e.target);
                var targetProp = $element.attr('joove-ds-sort-OnClick');

                Joove.DatasourceManager.sortControlsBoundToDataSet('List1DataSet', targetProp, e);
            },

ButtonClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockButtonClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockButtonClicked);
                }

                this.timeoutDelayLockButtonClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        //This is true only when the menu item is clicked programmatically
                        //and occurs when the middle mouse button click is triggered
                        var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
if (openInNewWindow) $(e.target).data("openInNewWindow", undefined); Joove.Core.executeRedirectControllerAction("ManageOperation", "EditOperation", "GET", [Joove.Common.nullSafe<any>(() => _parents[0].Id, 0)], {}, { mode: 'Slide', width: '50%', height: '50%', onClose: () => { $scope.actions.Refresh(); }});
}, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(OperationsListDataValidations);
        window._ruleEngine.addConditionalFormattings(OperationsListConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(OperationsListCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("OperationsListController", ["$scope", "$timeout", OperationsListController] as Array<string>);
}
