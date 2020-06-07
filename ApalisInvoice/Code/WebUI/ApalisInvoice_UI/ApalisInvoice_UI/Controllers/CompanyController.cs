using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ApalisInvoice_UI.Common;
using ApalisInvoice_UI.Interface;
using ApalisInvoice_UI.Interface.Common;
using ApalisInvoiceViewModel;
using ApalisInvoiceViewModel.Common;
using Microsoft.AspNetCore.Mvc;

namespace ApalisInvoice_UI.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;
        private readonly ICommonService commonService;
        public CompanyController(ICompanyService companyService, ICommonService commonService)
        {
            this.companyService = companyService;
            this.commonService = commonService;
        }
        public IActionResult CompanyDetails(string result)
        {
            ViewBag.Result = result;
            return View(companyService.companies());
        }
        public IActionResult NewCompany()
        {
            return PartialView("NewCompany");
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> SaveCompany([FromForm] Company company)
        {
            string strUserData = User.Claims.Where(x => x.Type == ClaimTypes.UserData).Select(x => x.Value).FirstOrDefault();
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var ltfile = commonService.SaveExternalFile(company.file, "Logo");
            company.LogoPath = ltfile.FirstOrDefault();
            AMPS_Config_CompanyViewModel companydetail = new AMPS_Config_CompanyViewModel()
            {
                CompanyID = company.CompanyID,
                Companycode = company.Companycode,
                CompanyName = company.CompanyName,
                Address = company.Address,
                City = company.City,
                State = company.State,
                Zipcode = company.Zipcode,
                Workphone = company.Workphone,
                Mobile1 = company.Mobile1,
                Mobile2 = company.Mobile2,
                Mobile3 = company.Mobile3,
                Mobile4 = company.Mobile4,
                Iso = company.Iso,
                Epf_no = company.Epf_no,
                Esi_no = company.Esi_no,
                Email = company.Email,
                Govtregdno = company.Govtregdno,
                Gstn = company.Gstn,
                Pan_no = company.Pan_no,
                Tnpolicelno = company.Tnpolicelno,
                Website = company.Website,
                LogoPath = company.LogoPath,
                AuthID = strUserData
            };
            var result = await companyService.saveCompany(companydetail);
            return RedirectToAction("CompanyDetails", new { result = result.IsSuccess });
        }
    }
}