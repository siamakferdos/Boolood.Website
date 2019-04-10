using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Model.Dtos;
using Boolood.Services.ArticleContext.File;
using Boolood.Tests.Mock;
using Boolood.Utility;
using Xunit;

namespace Boolood.Tests
{
    public class ArticleFileTest
    {
        [Fact]
        public void SaveArticleImages()
        {
            var article = MockArticle.GetArticleDto();
            ArticleFile.SaveArticleImages(article);
            Assert.True(ArticleFile.AreArticleAllImagesExist(article));
        }
    }
}
