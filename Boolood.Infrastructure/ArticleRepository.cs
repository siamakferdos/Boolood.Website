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

        public Article GetArticle(Guid id)
        {
            return GetEntity<Article>(id);
        }

        public void AddArticle(Article article)
        {
            AddEntity(article);
        }

      
        public List<Category> GetAllCategories()
        {
            return GetAllEntities<Category>();
        }
    }
}
