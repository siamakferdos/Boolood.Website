using System;
using System.Collections.Generic;
using System.Text;

namespace Boolood.Framework.Core.Language
{
    public interface ILanguageSpec
    {
        string HtmlDirection();
        string CssPath();
        System.Resources.ResourceManager ExceptionResourceManager();
        System.Resources.ResourceManager MenuResourceManager();

    }
}
