using Boolood.Framework.Core.Query;
using Boolood.Framework.Core.Repository;
using Boolood.Framework.Core.Services;

namespace Boolood.Services.CultureContext
{
    public class Language: ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;

        public Language(ILanguageRepository languageRepository, ILanguageQuery languageQuery)
        {
            _languageRepository = languageRepository;
        }
    }
}
