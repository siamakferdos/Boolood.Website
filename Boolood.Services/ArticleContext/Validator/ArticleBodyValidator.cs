using System.Collections.Generic;
using System.Linq;
using Boolood.Model.Settings;
using Boolood.Services.ArticleContext.Exception;
using Boolood.Utility;

namespace Boolood.Services.ArticleContext.Validator
{
    public class ArticleBodyValidator
    {
        public static void CheckArticleBodyRules(string body)
        {
            var bodyImages = ImageUtility.GetBase64Images(body);
            CheckBodyImageCount(bodyImages);
            CheckBodyImageSize(bodyImages);
            CheckBodyTextLenght(body, bodyImages);
        }

        private static void CheckBodyTextLenght(string body, List<string> bodyImages)
        {
            var bodyImagesLength = bodyImages.Sum(b => b.Length);
            if (body.Length - bodyImagesLength > ArticleSettings.ArticleBodyMaxLenght)
                throw new ArticleTextInvalidLengthException(
                    "متن"
                    , ArticleSettings.ArticleBodyMaxLenght);
        }

        private static void CheckBodyImageCount(List<string> bodyImages)
        {
            if (bodyImages.Count > ArticleSettings.ArticleBodyImagesMaxCount)
                throw new ArticleBodyInvalidImageCountException(
                    ArticleSettings.ArticleBodyImagesMaxCount);
        }

        private static void CheckBodyImageSize(List<string> bodyImages)
        {
            var i = 0;
            bodyImages.ForEach(b =>
            {
                i++;
                if (ImageUtility.GetBase64ImageSize(b) >
                    ArticleSettings.ArticleBodyImageMaxBytes)
                    throw new ArticleBodyInvalidImageSizeException(
                        i,
                        ArticleSettings.ArticleBodyImageMaxBytes);
            });
        }
    }
}
