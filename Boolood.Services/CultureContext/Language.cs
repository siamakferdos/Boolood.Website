using Boolood.Framework.Core.Query;
using Boolood.Framework.Core.Repository;

namespace Boolood.Services.CultureContext
{
    public class Language
    {
        private readonly ILanguageRepository _languageRepository;

        public Language(ILanguageRepository languageRepository, ILanguageQuery languageQuery)
        {
            _languageRepository = languageRepository;
        }
    }
}
