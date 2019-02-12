using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Model.Dtos;

namespace Boolood.Framework.Core.Query
{
    public interface ILanguageQuery
    {
        List<LanguageDto> GetLanguages();
    }
}
