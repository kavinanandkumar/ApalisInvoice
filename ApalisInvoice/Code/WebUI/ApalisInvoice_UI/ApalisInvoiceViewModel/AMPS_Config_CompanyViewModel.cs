using ApalisInvoiceViewModel.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApalisInvoiceViewModel
{
   public class AMPS_Config_CompanyViewModel:TableAuditViewModel
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Companycode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Workphone { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Mobile3 { get; set; }
        public string Mobile4 { get; set; }
        public string Email { get; set; }
        public string Govtregdno { get; set; }
        public string Esi_no { get; set; }
        public string Epf_no { get; set; }
        public string Tnpolicelno { get; set; }
        public string Iso { get; set; }
        public string Website { get; set; }
        public string Pan_no { get; set; }
        public string Gstn { get; set; }
        public string LogoPath { get; set; }
        public string AuthID { get; set; }
    }
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Companycode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Workphone { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Mobile3 { get; set; }
        public string Mobile4 { get; set; }
        public string Email { get; set; }
        public string Govtregdno { get; set; }
        public string Esi_no { get; set; }
        public string Epf_no { get; set; }
        public string Tnpolicelno { get; set; }
        public string Iso { get; set; }
        public string Website { get; set; }
        public string Pan_no { get; set; }
        public string Gstn { get; set; }
        public string LogoPath { get; set; }
        public List<IFormFile> file { get; set; }
    }
}
