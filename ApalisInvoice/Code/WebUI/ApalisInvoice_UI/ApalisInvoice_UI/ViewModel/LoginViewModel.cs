using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter user name!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class APIToken
    {
        public string loginUserID { get; set; }
    }
}
