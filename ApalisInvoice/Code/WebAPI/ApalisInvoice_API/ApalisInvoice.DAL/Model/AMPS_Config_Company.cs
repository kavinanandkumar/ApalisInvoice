using ApalisInvoice.DAL.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoice.DAL.Model
{
    [Table("AMPS_Config_Company")]
    public partial class AMPS_Config_Company : TableAudit
    {
        [Key]
        public int CompanyID { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string CompanyName { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string Companycode { get; set; }
        [Column(TypeName = "VARCHAR(300)")]
        public string Address { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string City { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        public string State { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string Zipcode { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public string Workphone { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public string Mobile1 { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public string Mobile2 { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public string Mobile3 { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        public string Mobile4 { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string Email { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Govtregdno { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Esi_no { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Epf_no { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Tnpolicelno { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Iso { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Website { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Pan_no { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Gstn { get; set; }
        [Column(TypeName = "VARCHAR(2000)")]
        public string LogoPath { get; set; }
    }
}
