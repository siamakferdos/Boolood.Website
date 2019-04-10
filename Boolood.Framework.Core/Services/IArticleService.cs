using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Model.Dtos;

namespace Boolood.Framework.Core.Services
{
    public interface IArticleService
    {
        void AddArticle(ArticleDto article);
        void CheckArticleTitle(string text);
        void CheckArticleSummary(string text);
        void CheckArticleBody(string text);
    }
}
