using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Model.Dtos;

namespace Boolood.Framework.Core.Services
{
    public interface IArticleService
    {
        void AddArticle(ArticleDto article);
    }
}
