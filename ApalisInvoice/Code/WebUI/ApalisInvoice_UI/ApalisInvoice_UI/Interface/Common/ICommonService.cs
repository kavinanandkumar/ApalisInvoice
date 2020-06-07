using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.Interface.Common
{
   public interface ICommonService
    {
        List<string> SaveExternalFile(List<IFormFile> file, string FolderName);
    }
}
