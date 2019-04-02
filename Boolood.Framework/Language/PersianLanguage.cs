using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;
using Boolood.Framework.Core.Language;
using Boolood.Resources.Fa;

namespace Boolood.Framework.Language
{
    public class PersianLanguage: ILanguageSpec
    {
        public string HtmlDirection()
        {
            return "rtl";
        }

        public string CssPath()
        {
            return "/css/rtl";
        }

        public ResourceManager ExceptionResourceManager()
        {
            return ExceptionResource.ResourceManager;
        }

        public ResourceManager MenuResourceManager()
        {
            return MenuResource.ResourceManager;
        }
    }
}
