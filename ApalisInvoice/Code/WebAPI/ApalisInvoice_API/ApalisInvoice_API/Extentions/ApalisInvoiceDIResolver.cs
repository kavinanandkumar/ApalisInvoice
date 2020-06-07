using ApalisInvoice.DAL.Interface;
using ApalisInvoice.DAL.Repository;
using ApalisInvoice_API.Interface;
using ApalisInvoice_API.Mapping;
using ApalisInvoice_API.Service;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_API.Extentions
{
    public static class ApalisInvoiceDIResolver
    {
        public static void ConfigureDIResolver(this IServiceCollection services)
        {
            var autoConfig = new MapperConfiguration(cfg => {
                cfg.AddProfile(new ApalisInvoiceProfile());
            });

            services.AddSingleton(sp => autoConfig.CreateMapper());

            #region Service
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICompanyService, CompanyService>(); 
            #endregion

            #region Repository
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            #endregion
        }
    }
}
