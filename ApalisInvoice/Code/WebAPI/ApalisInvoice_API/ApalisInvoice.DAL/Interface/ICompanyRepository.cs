using ApalisInvoice.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoice.DAL.Interface
{
   public interface ICompanyRepository
    {
        IList<AMPS_Config_Company> companies();
        AMPS_Config_Company companyByID(int companyID);
        AMPS_Config_Company saveCompany(AMPS_Config_Company company);
    }
}
