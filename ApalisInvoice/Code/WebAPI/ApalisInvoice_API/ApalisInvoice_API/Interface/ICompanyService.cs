using ApalisInvoice.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_API.Interface
{
   public interface ICompanyService
    {
        IList<AMPS_Config_CompanyViewModel> companies();
        AMPS_Config_CompanyViewModel companyByID(int companyID);
        AMPS_Config_CompanyViewModel saveCompany(AMPS_Config_CompanyViewModel company);
    }
}
