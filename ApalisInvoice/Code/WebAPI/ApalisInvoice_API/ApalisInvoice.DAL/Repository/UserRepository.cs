using ApalisInvoice.DAL.Interface;
using ApalisInvoice.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoice.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly ApalisInvoiceContext apalisInvoiceContext;
        public UserRepository(ApalisInvoiceContext apalisInvoiceContext)
        {
            this.apalisInvoiceContext = apalisInvoiceContext;
        }
        public AMPS_Config_Users userByUserName(string userName)
        {
            return apalisInvoiceContext.Users.Where(x => x.UserName == userName && x.IsActive == true).FirstOrDefault();
        }
    }
}
