using Boolood.Framework.Pattern;
using Boolood.Model.Settings;
using Boolood.Services.ArticleContext.Exception;
using Boolood.Utility;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext.Validator
{
    public class ArticleSummaryImageValidator : ArticleImageValidator
    {
        public ArticleSummaryImageValidator(CommandsHandler validator, IFormFile file)
            : base(validator, file)
        {
            validator.AddCommand(CheckImageDimensions);
        }

        public override void CheckFileRules()
        {
            if (FormForm.Length > ArticleSettings.ArticleSummaryImageMaxBytes)
                throw new InvalidArticleImageSizeException(
                    FormForm.FileName, ArticleSettings.ArticleSummaryImageMaxBytes);
        }

        public void CheckImageDimensions()
        {
            var imageRaito = ImageUtility.GetImageRaito(FormForm);
            if (imageRaito < ArticleSettings.ArticleSummaryImageMinRaito ||
                    imageRaito > ArticleSettings.ArticleSummaryImageMaxRaito) 
                throw new InvalidArticleImageRaitoException(
                    FormForm.FileName,
                    ArticleSettings.ArticleSummaryImageMinRaito,
                    ArticleSettings.ArticleSummaryImageMaxRaito
                );
        }
    }
}