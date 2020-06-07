using ApalisInvoice_UI.Interface;
using ApalisInvoice_UI.Interface.Common;
using ApalisInvoice_UI.Models;
using ApalisInvoiceViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.Service
{
    public class UserService : IUserService
    {
        private readonly IAPIClient _apiClient;
        private readonly ApiSettings _apiSettings;
        public UserService(IAPIClient _apiClient,ApiSettings _apiSettings)
        {
            this._apiClient = _apiClient;
            this._apiSettings = _apiSettings;
        }

        public AMPS_Config_UsersViewModel UserByUserName(string userName)
        {
            string apiUrl = _apiSettings.ApaliseInvoiceAPI.HostedURL + ApaliseInvoiceAPIEndPoint.User + "/UserByUserName/" + userName;
            return _apiClient.GetAsync<AMPS_Config_UsersViewModel>(apiUrl).Result;
        }
    }
}
