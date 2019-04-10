using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Model.DbModels;

namespace Boolood.Framework.Core.Repository
{
    public interface IArticleRepository: IRepositoryBase
    {
        void AddArticle(Article article);
        void AddCategory(Category category);
        List<Category> GetAllCategories();
        Article GetArticle(Guid id);
    }
}
