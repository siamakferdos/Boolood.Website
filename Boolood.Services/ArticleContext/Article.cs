using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Dtos;
using Boolood.Dtos.Mapper;
using Boolood.Framework.Core.Query;
using Boolood.Framework.Core.Repository;
using Boolood.Framework.Core.Services;
using Boolood.Framework.Repository;
using Boolood.Model.Dtos;
using Boolood.Model.Mapper;
using Boolood.Read;
using Boolood.Services.ArticleContext.Exception;

namespace Boolood.Services.ArticleContext
{
    public class Article: IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public Article(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void AddArticle(ArticleDto article)
        {
            //if (!HasAuthorPermissionToThisCategory(article.AuthorId, article.CategoryId))
            //    throw new HasNotPermissionToCategoryException();
            //CheckArticleSummaryLenght(article.Summary);

            _articleRepository.AddArticle(article.MapToDbModel());
            _articleRepository.SaveChanges();
        }
   

        private static void CheckArticleSummaryLenght(string summary)
        {
            if (summary.Length < 20 || summary.Length > 200)
                throw new ArticleSummaryInvalidLengthException();
        }

        public bool HasAuthorPermissionToThisCategory(int authorId, Guid categoryId)
        {
            return true;
        }
    }
}
