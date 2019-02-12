using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boolood.Dtos.Mapper;
using Boolood.Framework.Core.Query;
using Boolood.Model.Dtos;
using Boolood.Persistence.DbContext;

namespace Boolood.Read
{
    public class ArticleQuery: QueryBase, IArticleQuery
    {
        public ArticleQuery(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public List<CategoryDto> GetCategories()
        {
            return _appDbContext.Categories.ToList().ConvertAll(c => c.MapToDtoModel());
        }
    }
}
