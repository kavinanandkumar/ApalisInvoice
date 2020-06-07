using ApalisInvoice_API.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_API.Models
{
    public class ApalisToken
    {
        public string loginUserID { get; set; }
        public long TokenID { get; set; }
        public long DecryptToken(string tokenid)
        {
            if (tokenid == "")
            {
                return 0;
            }
            return Convert.ToInt64(Cryptography.Decrypt(this.loginUserID, "ApalisInvoice"));
        }
    }
}
