using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApalisInvoice_API.Controllers
{
    [Route("ApaliseInvoice/[controller]")]
    [ApiController]
    public class InitializeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Initialized");
        }
    }
}