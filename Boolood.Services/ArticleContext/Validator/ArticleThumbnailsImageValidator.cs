using Boolood.Framework.Pattern;
using Boolood.Model.Settings;
using Boolood.Services.ArticleContext.Exception;
using Boolood.Utility;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext.Validator
{
    public class ArticleThumbnailsImageValidator : ArticleImageValidator
    {
        public ArticleThumbnailsImageValidator(CommandsHandler validator, IFormFile file)
            : base(validator, file)
        {
            validator.AddCommand(CheckImageDimensions);
        }

        public override void CheckFileRules()
        {
            if (FormForm.Length > ArticleSettings.ArticleThumbnailImageMaxBytes)
                throw new InvalidArticleImageSizeException(
                    FormForm.FileName, ArticleSettings.ArticleThumbnailImageMaxBytes);
        }


        public void CheckImageDimensions()
        {
            var imageRaito = ImageUtility.GetImageRaito(FormForm);
            if (imageRaito < ArticleSettings.ArticleThumbnailImageMinRaito ||
                imageRaito > ArticleSettings.ArticleThumbnailImageMaxRaito)
                throw new InvalidArticleImageRaitoException(
                    FormForm.FileName,
                    ArticleSettings.ArticleThumbnailImageMinRaito,
                    ArticleSettings.ArticleThumbnailImageMaxRaito
                );
        }
    }
}