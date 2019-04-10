using Boolood.Framework.Core.Services;
using Boolood.Services.ArticleContext;
using Boolood.Services.ArticleContext.Exception;
using Boolood.Tests.Mock;
using Moq;
using Xunit;

namespace Boolood.Tests
{
    public class ArticleTest
    {
        private IArticleService _articleService;
        public ArticleTest()
        {
            _articleService = new Article(null);
        }

        [Fact]
        public void CheckTitle_53CharTitle_PassTest()
        {
            _articleService.CheckArticleTitle(
                    MockArticle.GetPassTitleText());
        }
        [Fact]
        public void CheckSummary_197CharSummary_PassTest()
        {
            _articleService.CheckArticleSummary(
                MockArticle.GetPassSummaryText());
        }
        [Fact]
        public void CheckTitle_4037CharBody_PassTest()
        {
            _articleService.CheckArticleBody(
                MockArticle.GetPassBodyText());
        }
        [Fact]
        public void CheckTitle_ExceedFromMaxLenght_ArticleTextInvalidLengthException()
        {
            Assert.Throws<ArticleTextInvalidLengthException>(
                () => _articleService.CheckArticleTitle(
                    MockArticle.GetFailTitleText()));
        }
        [Fact]
        public void CheckSummary_ExceedFromMaxLenght_ArticleTextInvalidLengthException()
        {
            Assert.Throws<ArticleTextInvalidLengthException>(
                () => _articleService.CheckArticleSummary(
                    MockArticle.GetFailSummaryText()));
        }
        [Fact]
        public void CheckBody_ExceedFromMaxLenght_ArticleTextInvalidLengthException()
        {
            Assert.Throws<ArticleTextInvalidLengthException>(
                () => _articleService.CheckArticleBody(
                    MockArticle.GetFailBodyText()));
        }

        [Fact]
        public void CheckBody_Contains11ImageInBody_ArticleBodyInvalidImageCountException()
        {
            Assert.Throws<ArticleBodyInvalidImageCountException>(
                () => _articleService.CheckArticleBody(
                    MockArticle.GetBodyTextContainsMoreThan10Images()));
        }

        [Fact]
        public void CheckBody_ContainsLargeImageInBody_ArticleBodyInvalidImageSizeException()
        {
            Assert.Throws<ArticleBodyInvalidImageSizeException>(
                () => _articleService.CheckArticleBody(
                    MockArticle.GetBodyTextContainsLargeThan200KbImage()));
        }

        [Fact]
        public void CheckBody_Contains8ImageAndNoLargeImageInBody_PassTest()
        {
            _articleService.CheckArticleBody(
                    MockArticle.GetBodyTextContains8ImageAndNoLargeImage());
        }
    }
}
