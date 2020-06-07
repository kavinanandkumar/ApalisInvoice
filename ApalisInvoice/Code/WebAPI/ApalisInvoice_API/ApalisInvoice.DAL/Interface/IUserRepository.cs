using ApalisInvoice.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoice.DAL.Interface
{
   public interface IUserRepository
    {
        AMPS_Config_Users userByUserName(string userName);
    }
}
