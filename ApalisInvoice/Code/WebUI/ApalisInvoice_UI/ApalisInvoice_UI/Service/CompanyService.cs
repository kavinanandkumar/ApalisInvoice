using ApalisInvoice_UI.Common;
using ApalisInvoice_UI.Interface;
using ApalisInvoice_UI.Interface.Common;
using ApalisInvoice_UI.Models;
using ApalisInvoiceViewModel;
using ApalisInvoiceViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly IAPIClient _apiClient;
        private readonly ApiSettings _apiSettings;
        public CompanyService(IAPIClient _apiClient, ApiSettings _apiSettings)
        {
            this._apiClient = _apiClient;
            this._apiSettings = _apiSettings;
        }

        public IList<AMPS_Config_CompanyViewModel> companies()
        {
            string apiUrl = _apiSettings.ApaliseInvoiceAPI.HostedURL + ApaliseInvoiceAPIEndPoint.Company;
            return _apiClient.GetAsync<IList<AMPS_Config_CompanyViewModel>>(apiUrl).Result;

        }

        public AMPS_Config_CompanyViewModel companyByID(int companyID)
        {
            string apiUrl = _apiSettings.ApaliseInvoiceAPI.HostedURL + ApaliseInvoiceAPIEndPoint.Company + "/CompanyByID/" + companyID;
            return _apiClient.GetAsync<AMPS_Config_CompanyViewModel>(apiUrl).Result;
        }

        public async Task<MessageViewModel<AMPS_Config_CompanyViewModel>> saveCompany(AMPS_Config_CompanyViewModel company)
        {
            string apiUrl = _apiSettings.ApaliseInvoiceAPI.HostedURL + ApaliseInvoiceAPIEndPoint.Company + "/SaveCompany";
            return await _apiClient.PostAsync<AMPS_Config_CompanyViewModel, AMPS_Config_CompanyViewModel>(apiUrl, company);
        }
    }
}
