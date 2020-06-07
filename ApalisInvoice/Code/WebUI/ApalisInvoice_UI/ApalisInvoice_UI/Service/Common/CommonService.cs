using ApalisInvoice_UI.Interface.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_UI.Service.Common
{
    public class CommonService : ICommonService
    {
        private static IHostingEnvironment _objhostingEnvironment;
        public CommonService(IHostingEnvironment objhostingEnvironment)
        {
            _objhostingEnvironment = objhostingEnvironment;
        }
        public List<string> SaveExternalFile(List<IFormFile> file, string FolderName)
        {
            if (!Directory.Exists(Path.Combine(_objhostingEnvironment.WebRootPath, "ExternalDoc"))) Directory.CreateDirectory(Path.Combine(_objhostingEnvironment.WebRootPath, "ExternalDoc"));
            string strPathName = Path.Combine(_objhostingEnvironment.WebRootPath, "ExternalDoc", FolderName);
            if (!Directory.Exists(strPathName)) Directory.CreateDirectory(strPathName);
            List<string> _ltFilePath = new List<string>();
            if (file.Count > 0)
            {
                int i = 1;
                foreach (IFormFile Attachment in file)
                {

                    string FilePath = Path.Combine("ExternalDoc", FolderName, Attachment.FileName);
                    var strfilepath = Path.Combine(strPathName, Attachment.FileName);
                    using (var fileStream = new FileStream(strfilepath, FileMode.Create))
                    {
                        Attachment.CopyTo(fileStream);
                    }
                    _ltFilePath.Add(FilePath);
                    i = i + 1;
                }
            }
            return _ltFilePath;
        }
    }
}
