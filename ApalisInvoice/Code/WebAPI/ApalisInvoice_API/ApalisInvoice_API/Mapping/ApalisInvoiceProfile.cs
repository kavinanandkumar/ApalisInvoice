using ApalisInvoice.DAL.Model;
using ApalisInvoice.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_API.Mapping
{
    public class ApalisInvoiceProfile : Profile
    {
        public ApalisInvoiceProfile()
        {
            CreateMap<AMPS_Config_UsersViewModel, AMPS_Config_Users>()
                .ReverseMap();

            CreateMap<AMPS_Config_CompanyViewModel, AMPS_Config_Company>()
                .ReverseMap();
            
        }
    }
}
