using ApalisInvoice.DAL.Interface;
using ApalisInvoice.DAL.Model;
using ApalisInvoice.ViewModel;
using ApalisInvoice_API.Interface;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_API.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;
        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            this.companyRepository = companyRepository;
            this.mapper = mapper;
        }
        public IList<AMPS_Config_CompanyViewModel> companies()
        {
            var companies = companyRepository.companies();
            if (companies == null)
            {
                return null;
            }
            return mapper.Map<IList<AMPS_Config_CompanyViewModel>>(companies);
        }

        public AMPS_Config_CompanyViewModel companyByID(int companyID)
        {
            var company = companyRepository.companyByID(companyID);
            if (company == null)
            {
                return null;
            }
            return mapper.Map<AMPS_Config_CompanyViewModel>(company);
        }

        public AMPS_Config_CompanyViewModel saveCompany(AMPS_Config_CompanyViewModel objcompany)
        {
            var data = mapper.Map<AMPS_Config_Company>(objcompany);
            var company = companyRepository.saveCompany(data);
            if (company == null)
            {
                return null;
            }
            return mapper.Map<AMPS_Config_CompanyViewModel>(company);
        }
    }
}
