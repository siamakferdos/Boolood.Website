using System;
using Boolood.Framework.Core.Repository;
using Boolood.Framework.Core.Services;
using Boolood.Framework.Pattern;
using Boolood.Model.Dtos;
using Boolood.Model.Mapper;
using Boolood.Model.Settings;
using Boolood.Services.ArticleContext.Exception;
using Boolood.Services.ArticleContext.File;
using Boolood.Services.ArticleContext.Validator;
using Boolood.Utility;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext
{
    public class Article : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public Article(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void AddArticle(ArticleDto article)
        {
            CheckArticleTexts(article);
            CheckArticleFiles(article);

            if (article.Id == Guid.Empty)
            {
                var articleDbModel = article.MapToDbModel();
                _articleRepository.AddArticle(articleDbModel);
                article.Id = articleDbModel.Id;
            }
            else
            {
                var articleInDb = _articleRepository.GetArticle(article.Id);
                article.MapToDbModel(articleInDb);
            }
            _articleRepository.SaveChanges();

            ArticleFile.SaveArticleImages(article);
        }


        public static void CheckArticleFiles(ArticleDto article)
        {
            CommandsHandler articleValidator = new CommandsHandler();
            new ArticleMainImageValidator(articleValidator, article.MainImage);
            new ArticleSummaryImageValidator(articleValidator, article.SummaryImage);
            new ArticleThumbnailsImageValidator(articleValidator, article.ThumbnailImage);

            articleValidator.ExecuteAll();
        }

        public void CheckArticleTitle(string title)
        {
            if (title.Length > ArticleSettings.ArticleTitleMaxLenght)
            {
                throw new ArticleTextInvalidLengthException(
                    "عنوان"
                    , ArticleSettings.ArticleTitleMaxLenght);
            }
        }

        public void CheckArticleSummary(string summary)
        {
            if (summary.Length > ArticleSettings.ArticleSummaryMaxLenght)
            {
                throw new ArticleTextInvalidLengthException(
                    "خلاصه"
                    , ArticleSettings.ArticleSummaryMaxLenght);
            }
        }

        public void CheckArticleBody(string body)
        {
            ArticleBodyValidator.CheckArticleBodyRules(body);
        }

        private void CheckArticleTexts(ArticleDto article)
        {
            CheckArticleTitle(article.Title);
            CheckArticleSummary(article.Summary);
            CheckArticleBody(article.Body);
        }
    }
}
