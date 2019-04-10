using System.IO;
using Boolood.Framework.Pattern;
using Boolood.Services.ArticleContext.Validator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace Boolood.Tests.Mock
{
    public static class MockImageFile
    {
        private static readonly CommandsHandler _validator1;
        private static readonly CommandsHandler _validator2;
        private static readonly IFormFile _imgMainFormFile;
        private static readonly IFormFile _imgSummaryFormFile;
        private static readonly IFormFile _imgThumbnailFormFile;
        private static readonly IFormFile _imgGifMainFormFile;
        private static readonly IFormFile _imgPassMainFormFile;
        private static readonly IFormFile _imgPassSummaryFormFile;
        private static readonly IFormFile _imgPassThumbnailFormFile;

        static MockImageFile()
        {
            _validator1 = new CommandsHandler();
            _validator2 = new CommandsHandler();
            _imgMainFormFile = MakeFormFile("ArticleMock", "article-main.jpg");
            _imgPassMainFormFile = MakeFormFile("ArticleMock", "article-main2.jpg");
            _imgGifMainFormFile = MakeFormFile("ArticleMock", "article-main.gif");
            _imgSummaryFormFile = MakeFormFile("ArticleMock", "article-summary.jpg");
            _imgPassSummaryFormFile = MakeFormFile("ArticleMock", "article-summary2.jpg");
            _imgThumbnailFormFile = MakeFormFile("ArticleMock", "article-thumbnail.jpg");
            _imgPassThumbnailFormFile = MakeFormFile("ArticleMock", "article-thumbnail2.jpg");

        }

        public static IFormFile GetPassMainImage() => _imgPassMainFormFile;
        public static IFormFile GetPassSummaryImage() => _imgPassSummaryFormFile;
        public static IFormFile GetPassThumbnailImage() => _imgPassThumbnailFormFile;

        public static ArticleMainImageValidator GetArticleMainImage()
        {
            return new ArticleMainImageValidator(
                _validator1,
                _imgMainFormFile);
        }

        public static ArticleMainImageValidator GetPassArticleMainImage()
        {
            return new ArticleMainImageValidator(
                _validator1,
                _imgPassMainFormFile);
        }

        public static ArticleSummaryImageValidator GetArticleSummaryImage()
        {
            return new ArticleSummaryImageValidator(
                _validator1,
                _imgSummaryFormFile);
        }

        public static ArticleSummaryImageValidator GetPassArticleSummaryImage()
        {
            return new ArticleSummaryImageValidator(
                _validator1,
                _imgPassSummaryFormFile);
        }

        public static ArticleThumbnailsImageValidator GetArticleThumbnailImage()
        {
            return new ArticleThumbnailsImageValidator(
                _validator1,
                _imgThumbnailFormFile);
        }

        public static ArticleThumbnailsImageValidator GetPassArticleThumbnailImage()
        {
            return new ArticleThumbnailsImageValidator(
                _validator1,
                _imgPassThumbnailFormFile);
        }

        public static ArticleMainImageValidator GetArticleMainGifImage()
        {
            return new ArticleMainImageValidator(
                _validator1,
                _imgGifMainFormFile);
        }

        private static IFormFile MakeFormFile(string path, string fileName)
        {
            FileStream sourceImg = File.OpenRead(Path.Combine(path, fileName));
            FormFile file = new FormFile(sourceImg, 0, sourceImg.Length, null, fileName)
            {
                Headers = new HeaderDictionary(),
                ContentType = GetContentType(fileName)
            };
            return file;
        }

        private static string GetContentType(string fileName)
        {
            switch (Path.GetExtension(fileName))
            {
                case ".jpg": return "image/jpeg";
                case ".png": return "image/png";
                case ".gif": return "image/gif";
            }
            return "image/jpeg";
        }
    }
}
