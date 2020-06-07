using ApalisInvoice.DAL.Model;
using ApalisInvoice.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_API.Interface
{
   public interface IUserService
    {
        AMPS_Config_UsersViewModel userByUserName(string userName);
    }
}
