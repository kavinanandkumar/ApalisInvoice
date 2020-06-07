using ApalisInvoice.DAL.Interface;
using ApalisInvoice.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoice.DAL.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        public readonly ApalisInvoiceContext apalisInvoiceContext;
        public CompanyRepository(ApalisInvoiceContext apalisInvoiceContext)
        {
            this.apalisInvoiceContext = apalisInvoiceContext;
        }
        public IList<AMPS_Config_Company> companies()
        {
            return apalisInvoiceContext.Companies.ToList();
        }

        public AMPS_Config_Company companyByID(int companyID)
        {
            return apalisInvoiceContext.Companies.Where(x => x.CompanyID == companyID).FirstOrDefault();
        }

        public AMPS_Config_Company saveCompany(AMPS_Config_Company company)
        {
            if (company.CompanyID == 0)
                apalisInvoiceContext.Companies.Add(company);
            else
                apalisInvoiceContext.Companies.Update(company);
            apalisInvoiceContext.SaveChanges();
            return company;
        }
    }
}
