using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Boolood.Framework.Core.Services;
using Boolood.Framework.Pattern;
using Boolood.Services.ArticleContext;
using Boolood.Services.ArticleContext.Exception;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Moq;
using Xunit;

namespace Boolood.Tests
{
    public class ArticleTest
    {
        private ArticleMainImage _articleMainImage;
        private ArticleSummaryImage _articleSummaryImage;
        private ArticleThumbnailsImage _articleThumbnailsImage;
        public ArticleTest()
        {
            var validator1 = new CommandsHandler();
            var validator2 = new CommandsHandler();
            var imgMainFormFile = MockFile.MakeFormFile("ArticleMock", "article-main.jpg");
            var imgSummaryFormFile = MockFile.MakeFormFile("ArticleMock", "article-summary.jpg");
            var imgThumbnailFormFile = MockFile.MakeFormFile("ArticleMock", "article-thumbnail.jpg");
            _articleMainImage = new ArticleMainImage(
                validator1,
                validator2,
                imgMainFormFile,
                "");
            _articleSummaryImage = new ArticleSummaryImage(
                validator1,
                validator2,
                imgSummaryFormFile,
                "");
            _articleThumbnailsImage = new ArticleThumbnailsImage(
                validator1,
                validator2,
                imgThumbnailFormFile,
                "");
        }
      
        [Fact]
        public void CheckFileRules_MainImageSizeExceed500KB_InvalidArticleImageSizeException()
        {
            Assert.Throws<InvalidArticleImageSizeException>(() => _articleMainImage.CheckFileRules());
        }

        [Fact]
        public void CheckFileRules_SummaryImageSizeExceed250KB_InvalidArticleImageSizeException()
        {
            Assert.Throws<InvalidArticleImageSizeException>(() => _articleSummaryImage.CheckFileRules());
        }

        [Fact]
        public void CheckFileRules_TumbnailImageSizeExceed100KB_InvalidArticleImageSizeException()
        {
            Assert.Throws<InvalidArticleImageSizeException>(() => _articleThumbnailsImage.CheckFileRules());
        }

        [Fact]
        public void CheckImageDimensions_MainImageRaitoOuOf1And15_InvalidArticleImageRaitoException()
        {
            Assert.Throws<InvalidArticleImageRaitoException>(() => _articleMainImage.CheckImageDimensions());
        }

        [Fact]
        public void CheckImageDimensions_SummaryImageSizeExceed250KB_InvalidArticleImageSizeException()
        {
            Assert.Throws<InvalidArticleImageSizeException>(() => _articleSummaryImage.CheckImageDimensions());
        }

        [Fact]
        public void CheckImageDimensions_TumbnailImageSizeExceed100KB_InvalidArticleImageSizeException()
        {
            Assert.Throws<InvalidArticleImageSizeException>(() => _articleThumbnailsImage.CheckImageDimensions());
        }
    }
}
