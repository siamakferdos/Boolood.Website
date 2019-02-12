using System;
using System.Collections.Generic;
using Boolood.Framework.Core.Repository;
using Boolood.Framework.Repository;
using Boolood.Model.DbModels;
using Boolood.Persistence.DbContext;

namespace Boolood.Infrastructure
{
    public class ArticleRepository: RepositoryBase<AppDbContext>, IArticleRepository
    {
        public ArticleRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void AddCategory(Category category)
        {
            AddEntity(category);
        }

        public void AddArticle(Article article)
        {
            AddEntity(article);
        }

        public void AcceptArticle(Guid articleId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            return GetAllEntities<Category>();
        }
    }
}
