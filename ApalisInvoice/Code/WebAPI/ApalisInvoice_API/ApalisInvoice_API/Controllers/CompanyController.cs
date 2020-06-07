using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApalisInvoice.ViewModel;
using ApalisInvoice_API.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApalisInvoice_API.Controllers
{
    [Route("ApaliseInvoice/[controller]")]
    [ApiController]
    public class CompanyController : ApaliseInvoiceController
    {
        private readonly ICompanyService companyService;
        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpGet]
        [ProducesResponseType(200), ProducesResponseType(401), ProducesResponseType(404)]
        public IActionResult Get()
        {
            var companies = companyService.companies();
            return Ok(companies);
        }

        [HttpGet("CompanyByID/{companyID}")]
        [ProducesResponseType(200), ProducesResponseType(401), ProducesResponseType(404)]
        public IActionResult CompanyByID(int companyID)
        {
            var company = companyService.companyByID(companyID);
            return Ok(company);
        }

        [HttpPost("SaveCompany")]
        [ProducesResponseType(200), ProducesResponseType(401), ProducesResponseType(404)]
        public IActionResult SaveCompany([FromBody] AMPS_Config_CompanyViewModel objCompany)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            AuditObject(objCompany, true);
            var company = companyService.saveCompany(objCompany);
            return Ok(new { IsSuccess = company == null ? false : true, ReturnMessage = company == null ? "Error" : "Success", Data = company });
        }
    }
}
