using ApalisInvoice_UI.Interface;
using ApalisInvoice_UI.Interface.Common;
using ApalisInvoice_UI.Service;
using ApalisInvoice_UI.Service.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.Extensions
{
    public static class ConfigureDIResolver
    {
        public static void ApalisInvoiceDIResolver(this IServiceCollection services)
        {
            services.AddScoped<ICommonService, CommonService>();
            services.AddScoped<IAPIClient, APIClient>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICompanyService, CompanyService>();
        }
    }
}
