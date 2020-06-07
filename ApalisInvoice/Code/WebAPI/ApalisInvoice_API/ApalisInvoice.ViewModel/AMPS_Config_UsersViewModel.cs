using ApalisInvoice.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoice.ViewModel
{
   public class AMPS_Config_UsersViewModel: TableAuditViewModel
    {

        public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public int Gender { get; set; }
        public string PhotoPath { get; set; }
        public int RoleId { get; set; }
        public bool? IsEditable { get; set; }
        public bool? IsAppAccess { get; set; }
        public int CompanyId { get; set; }
    }
}
