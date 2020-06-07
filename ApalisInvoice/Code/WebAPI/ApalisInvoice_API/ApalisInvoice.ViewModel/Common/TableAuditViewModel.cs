using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoice.ViewModel.Common
{
    public class TableAuditViewModel
    {
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public string AuthID { get; set; }

    }
}
