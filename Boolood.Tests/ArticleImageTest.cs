using Boolood.Model.Dtos;
using Boolood.Services.ArticleContext;
using Boolood.Services.ArticleContext.Exception;
using Boolood.Services.ArticleContext.Validator;
using Boolood.Tests.Mock;
using Xunit;

namespace Boolood.Tests
{
    public class ArticleImageTest
    {
        private ArticleMainImageValidator _articleMainImage;
        private ArticleSummaryImageValidator _articleSummaryImage;
        private ArticleThumbnailsImageValidator _articleThumbnailsImage;

        private ArticleMainImageValidator _passArticleMainImage;
        private ArticleSummaryImageValidator _passArticleSummaryImage;
        private ArticleThumbnailsImageValidator _passArticleThumbnailImage;

        private ArticleMainImageValidator _articleMainGifImage;

        public ArticleImageTest()
        {
            _passArticleMainImage = MockImageFile.GetPassArticleMainImage();
            _passArticleSummaryImage = MockImageFile.GetPassArticleSummaryImage();
            _passArticleThumbnailImage = MockImageFile.GetPassArticleThumbnailImage();

            _articleMainImage = MockImageFile.GetArticleMainImage();
            _articleSummaryImage = MockImageFile.GetArticleSummaryImage();
            _articleThumbnailsImage = MockImageFile.GetArticleThumbnailImage();

            _articleMainGifImage = MockImageFile.GetArticleMainGifImage();
        }

        [Fact]
        public void CheckMainImage_PassTest()
        {
            _passArticleMainImage.CheckImageRules();
            _passArticleMainImage.CheckFileRules();
            _passArticleMainImage.CheckImageDimensions();
        }

        [Fact]
        public void CheckSummaryImage_PassTest()
        {
            _passArticleSummaryImage.CheckImageRules();
            _passArticleSummaryImage.CheckFileRules();
            _passArticleSummaryImage.CheckImageDimensions();
        }

        [Fact]
        public void CheckThumbnailImage_PassTest()
        {
            _passArticleThumbnailImage.CheckImageRules();
            _passArticleThumbnailImage.CheckFileRules();
            _passArticleThumbnailImage.CheckImageDimensions();
        }

        [Fact]
        public void CheckImageRules_ImageTypeIsGif_InvalidArticleImageFormatEcxeption()
        {
            Assert.Throws<InvalidArticleImageFormatEcxeption>(() => _articleMainGifImage.CheckImageRules());
        }

        [Fact]
        public void CheckImageRules_ImageTypeIsJpg_PassTest()
        {
            _articleMainImage.CheckImageRules();
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
        public void CheckImageDimensions_MainImageRaitoOuOf1And1Point5_InvalidArticleImageRaitoException()
        {
            Assert.Throws<InvalidArticleImageRaitoException>(() => _articleMainImage.CheckImageDimensions());
        }

        [Fact]
        public void CheckImageDimensions_SummaryImageRaitoOuOf1And1Point2_InvalidArticleImageRaitoException()
        {
            Assert.Throws<InvalidArticleImageRaitoException>(() => _articleSummaryImage.CheckImageDimensions());
        }

        [Fact]
        public void CheckImageDimensions_TumbnailImageRaitoOuOf1And1Point1_InvalidArticleImageRaitoException()
        {
            Assert.Throws<InvalidArticleImageRaitoException>(() => _articleThumbnailsImage.CheckImageDimensions());
        }

        [Fact]
        public void CheckArticleDtoImages_AllFitImages_PassTest()
        {
            var articleDto = new ArticleDto
            {
                MainImage = MockImageFile.GetPassMainImage(),
                SummaryImage = MockImageFile.GetPassSummaryImage(),
                ThumbnailImage = MockImageFile.GetPassThumbnailImage()
            };
            Article.CheckArticleFiles(articleDto);

        }
    }
}
