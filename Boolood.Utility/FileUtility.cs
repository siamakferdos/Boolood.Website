using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace Boolood.Utility
{
    public class FileUtility
    {
        public void SaveFileForm(IFormFile file, string fileFullPath)
        {
            if (file.Length > 0)
            {
                using (var stream = new FileStream(fileFullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
        }
    }

   
}


