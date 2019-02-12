using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolood.Framework.Core.Repository;
using Boolood.Framework.Repository;
using Boolood.Model.DbModels;
using Boolood.Persistence.DbContext;

namespace Boolood.Infrastructure
{
    public class LanguageRepository : RepositoryBase<AppDbContext>, ILanguageRepository
    {
        public LanguageRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void AddLanguage(Language language)
        {
            AddEntity(language);
        }
    }
}
