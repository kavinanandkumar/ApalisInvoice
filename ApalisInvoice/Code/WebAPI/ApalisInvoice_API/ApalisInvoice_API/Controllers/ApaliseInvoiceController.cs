using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApalisInvoice_API.Common;
using ApalisInvoice_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ApalisInvoice_API.Controllers
{
    public class ApaliseInvoiceController : ControllerBase
    {
        [NonAction]
        public dynamic AuditObject(dynamic data, bool isAdd)
        {
            int tokenID = Convert.ToInt32(Cryptography.Decrypt(data.AuthID, "ApalisInvoice"));
            if (isAdd)
            {
                data.CreatedOn = DateTime.Now;
                data.CreatedBy = tokenID;
                data.IsActive = true;
            }
            data.LastModifiedOn = DateTime.Now;
            data.LastModifiedBy = tokenID;
            return data;
        }
    }
}