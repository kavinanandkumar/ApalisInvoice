using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoice.DAL.Model.Common
{
    public partial class TableAudit
    {
        public DateTime CreatedOn { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool IsActive { get; set; }

    }
}
