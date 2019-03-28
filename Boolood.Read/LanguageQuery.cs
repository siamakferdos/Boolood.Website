using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolood.Framework.Core.Query;
using Boolood.Model.Dtos;
using Boolood.Model.Mapper;
using Boolood.Persistence.DbContext;

namespace Boolood.Read
{
    public class LanguageQuery: QueryBase, ILanguageQuery
    {
        public LanguageQuery(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public List<LanguageDto> GetLanguages()
        {
            return _appDbContext.Languages.ToList().ConvertAll(l => l.MapToDtoModel());
        }
    }
}
