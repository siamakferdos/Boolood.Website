using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Microsoft.AspNetCore.Hosting;

namespace Boolood.Framework.Website
{
    public class WebsiteInfo
    {
        private static IHostingEnvironment _hostingEnvironment;
        public WebsiteInfo(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public static string WwwrootPath 
        {
            get
            {
                if (_hostingEnvironment == null) return "/wwwroot_test";
                return _hostingEnvironment.WebRootPath;
            }
        }
    }
}
