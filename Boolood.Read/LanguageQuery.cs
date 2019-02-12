using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolood.Model.Dtos;
using Boolood.Model.Mapper;
using Boolood.Persistence.DbContext;

namespace Boolood.Read
{
    public class LanguageQuery: QueryBase
    {
        public LanguageQuery(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public List<LanguageDto> GetLanguage()
        {
            return _appDbContext.Languages.ToList().ConvertAll(l => l.MapToDtoModel());
        }
    }
}
