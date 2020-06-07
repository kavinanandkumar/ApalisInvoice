using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.Models
{
    public class ApaliseInvoiceConfig
    {
        
    }
    public class ApiSettings
    {
        public ApiSetting ApaliseInvoiceAPI { get; set; }
    }
    public class ApiSetting
    {
        public string HostedURL { get; set; }
    }
}
