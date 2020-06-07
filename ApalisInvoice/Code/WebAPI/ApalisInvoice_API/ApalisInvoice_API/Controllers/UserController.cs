using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApalisInvoice_API.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApalisInvoice_API.Controllers
{
    [Route("ApaliseInvoice/[controller]")]
    [ApiController]
    public class UserController : ApaliseInvoiceController
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("UserByUserName/{userName}")]
        [ProducesResponseType(200), ProducesResponseType(401), ProducesResponseType(404)]
        public IActionResult UserByUserName(string userName)
        {
            var user = userService.userByUserName(userName);
            return Ok(user);
        }
    }
}
