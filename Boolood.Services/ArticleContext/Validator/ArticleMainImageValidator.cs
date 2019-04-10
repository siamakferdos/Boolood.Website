using Boolood.Framework.Pattern;
using Boolood.Model.Settings;
using Boolood.Services.ArticleContext.Exception;
using Boolood.Utility;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext.Validator
{
    public class ArticleMainImageValidator : ArticleImageValidator
    {
        public ArticleMainImageValidator(CommandsHandler validator, IFormFile file)
            : base(validator, file)
        {
            validator.AddCommand(CheckImageDimensions);
        }

        public override void CheckFileRules()
        {
            if (FormForm.Length > ArticleSettings.ArticleMainImageMaxBytes)
                throw new InvalidArticleImageSizeException(
                    FormForm.FileName, ArticleSettings.ArticleMainImageMaxBytes);
        }

        public void CheckImageDimensions()
        {
            var imageRaito = ImageUtility.GetImageRaito(FormForm);
            if (imageRaito < ArticleSettings.ArticleMainImageMinRaito ||
                imageRaito > ArticleSettings.ArticleMainImageMaxRaito
                )
                throw new InvalidArticleImageRaitoException(
                    FormForm.FileName, 
                    ArticleSettings.ArticleMainImageMinRaito,
                    ArticleSettings.ArticleMainImageMaxRaito
                    );
        }
    }
}