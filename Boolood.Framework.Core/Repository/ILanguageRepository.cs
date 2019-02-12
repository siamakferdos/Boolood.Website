using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Model.DbModels;

namespace Boolood.Framework.Core.Repository
{
    public interface ILanguageRepository: IRepositoryBase
    {
        void AddLanguage(Language language);
    }
}
