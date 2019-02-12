using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Model.DbModels;

namespace Boolood.Framework.Core.Repository
{
    public interface IArticleRepository: IRepositoryBase
    {
        void AddArticle(Article article);
        void AcceptArticle(Guid articleId);
        List<Category> GetAllCategories();
        void AddCategory(Category category);
    }
}
