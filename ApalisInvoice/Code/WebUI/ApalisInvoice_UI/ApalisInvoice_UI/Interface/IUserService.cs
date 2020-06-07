using ApalisInvoiceViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.Interface
{
   public interface IUserService
    {
        AMPS_Config_UsersViewModel UserByUserName(string userName);
    }
}
