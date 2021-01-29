// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
namespace DSS5_SupplyChainFinancialsOptimisation.Services {
/**
 * Client for 'AlgorithmCheck' Service
 */
export class AlgorithmCheckServiceClient {

    /**
     * Base url for 'AlgorithmCheck' Service
     */
    static baseUrl = "/api/AlgorithmCheck/";

    /**
    *
    */
    public static AlgorithmCheck(annual_turnover?:any, b2b?:any, b2c?:any, payment_term_of_receivable?:any, average_of_payment_terms?:any, average_invoice_value?:any, equity_ratio?:any): Axios.IPromise<Axios.AxiosXHR<any>> {
                const _data = { annual_turnover: annual_turnover,b2b: b2b,b2c: b2c,payment_term_of_receivable: payment_term_of_receivable,average_of_payment_terms: average_of_payment_terms,average_invoice_value: average_invoice_value,equity_ratio: equity_ratio };
                return axios.post(window._context.siteRoot + AlgorithmCheckServiceClient.baseUrl + "AlgorithmCheck",_data);
            }

}
}

// Create service shortcut
if (window.$api == null) {
    window.$api = {};
}

window.$api.AlgorithmCheck = DSS5_SupplyChainFinancialsOptimisation.Services.AlgorithmCheckServiceClient;