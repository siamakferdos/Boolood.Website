using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;
using Boolood.Framework.Core.Language;
using Boolood.Resources.En;

namespace Boolood.Framework.Language
{
    public class EnglishLanguage : ILanguageSpec
    {
        public string HtmlDirection()
        {
            return "ltr";
        }

        public string CssPath()
        {
            return "/css/ltr";
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
