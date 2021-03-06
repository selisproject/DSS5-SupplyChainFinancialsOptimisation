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
interface Window { scope_TurnoverForm: DSS5_SupplyChainFinancialsOptimisation.Controllers.ITurnoverFormScope; }
namespace DSS5_SupplyChainFinancialsOptimisation.Controllers {
const TurnoverFormConditionalFormattings = [
        ];
const TurnoverFormDataValidations = [
                                    ];
const TurnoverFormCalculatedExpressions = [
        ];

// Datasets Column Info
export var TurnoverStatisticDataSet_ColumnInfo = [new Joove.ColumnInfo("Year", "int", null, false),
           new Joove.ColumnInfo("TotalAmount", "decimal", null, false),
           new Joove.ColumnInfo("TotalAmountFunded", "decimal", null, false)];
window["TurnoverStatisticDataSet_ColumnInfo"] = TurnoverStatisticDataSet_ColumnInfo;

// Datasets Projection Shemas



export interface ITurnoverFormScope extends Joove.IWebPageScope {
model:
    DSS5_SupplyChainFinancialsOptimisation.ViewModels.TurnoverForm.TurnoverFormViewModel;
_partialModelStructure:
    any;
    _validations?: {
summary: Array<Joove.Validation.BindingEntry>,

    },
    _masterValidations?: any;
}

class TurnoverFormController {
private timeoutDelayLockChartClicked:
    any;


    private controllerActionFinished = (resetDirty: boolean) => {
        //window.scope_TurnoverForm.model = window.scope_TurnoverForm.dehydrate();
        //window.scope_MasterPage.model = window.scope_TurnoverForm.model;
        DSS5_SupplyChainFinancialsOptimisation.ViewModels.TurnoverForm.TurnoverFormViewModel._lightCast(window.scope_TurnoverForm.model);
        // Joove.Common.applyScope(window.scope_TurnoverForm);
        if (resetDirty) {
            window._context.isDirty = false;
        }
        window._ruleEngine.update(Joove.EvaluationTimes.OnChange);
    }

    constructor(private $scope: ITurnoverFormScope, $timeout: ng.ITimeoutService) {
        window.scope_TurnoverForm = $scope;
        $scope.$onControlChanged = function (event, newValue, dontMakeDirty) {
            Joove.Core.onChange(event.target, newValue, dontMakeDirty)
        }

        $scope.dehydrate = (context = null) => DSS5_SupplyChainFinancialsOptimisation.ViewModels.TurnoverForm.TurnoverFormViewModel._initializeFrom($scope.model, context);
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

    init($scope: ITurnoverFormScope, $timeout: ng.ITimeoutService) {


        $scope.model = DSS5_SupplyChainFinancialsOptimisation.ViewModels.TurnoverForm.TurnoverFormViewModel._initializeFrom(window.viewDTO.Model);

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
ChartYScaleMin:
            () => 0,
        }
// Dataset Handler
        $scope.datasets = {
        };
// Controller actions
        $scope.actions = {
Render:
            async (_cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("TurnoverForm", "Render", "GET", [], {}, _modalOptions);
            },
RenderSupplier:
            async (username, _cb, _modalOptions, _e) => {
                Joove.Common.autocompleteFix();


                Joove.Core.executeRedirectControllerAction("TurnoverForm", "RenderSupplier", "GET", [username], {}, _modalOptions);
            },
        };
// Events
        $scope.eventCallbacks = {
ChartClicked:
            (e, DataItem, _parents) => {
                window._recorder.addState(e);

                if (e != null) {
                    e.stopPropagation();
                    e.preventDefault();
                }

                if (this.timeoutDelayLockChartClicked != null) {
                    $timeout.cancel(this.timeoutDelayLockChartClicked);
                }

                this.timeoutDelayLockChartClicked = $timeout(() => {
                    Joove.Common.setControlKeyPressed(e, 0); Joove.Common.setLastClickedElement(e);

                    Joove.Validation.Manager.validateFormAndExecute(() => {
                        //This is true only when the menu item is clicked programmatically
                        //and occurs when the middle mouse button click is triggered
                        var openInNewWindow = $(e.target).data("openInNewWindow") === true || undefined;
                        if (openInNewWindow) $(e.target).data("openInNewWindow", undefined); Joove.Core.executeRedirectControllerAction("TurnoverPerMonthForm", "Render", "GET", [Joove.Common.nullSafe<any>(() => window["scope_TurnoverForm"].model.Supplier.UserName, ""),Joove.Common.nullSafe<any>(() => Joove.DatasourceManager.getSelectedItem($("[jb-id='Chart']"), e).Year, 0)], null, null, openInNewWindow);
}, { groups: [], withDataValidationsCheck: false, withRequiredFieldsCheck: false });
                }, 0);
            },

        };

// Rules
        window._ruleEngine.addDataValidations(TurnoverFormDataValidations);
        window._ruleEngine.addConditionalFormattings(TurnoverFormConditionalFormattings);
        window._ruleEngine.addCalculatedExpressions(TurnoverFormCalculatedExpressions);

        window._commander.executeCommands(window.viewDTO.ClientCommands);
        window.viewDTO.ClientCommands = [];

        Joove.Common.setNumberLocalizationSettings();
        Joove.DeveloperApi.init($scope as any, window.scope_MasterPage as any);
        window.$formExtend && window.$formExtend();
        window.$onFormLoaded && window.$onFormLoaded();
    }
}
angular.module("Application").controller("TurnoverFormController", ["$scope", "$timeout", TurnoverFormController] as Array<string>);
}
