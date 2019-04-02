using System.IO;
using Boolood.Framework.Pattern;
using Boolood.Model.Settings;
using Boolood.Services.ArticleContext.Exception;
using Boolood.Utility;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext
{
    public class ArticleMainImage : ArticleImage
    {
        public ArticleMainImage(CommandsHandler validator, CommandsHandler saver, IFormFile file, string path)
            : base(validator, saver, file, path)
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
            if (imageRaito > ArticleSettings.ArticleMainImageMaxRaito ||
                imageRaito < ArticleSettings.ArticleMainImageMinRaito)
                throw new InvalidArticleImageRaitoException(
                    FormForm.FileName, 
                    ArticleSettings.ArticleMainImageMinRaito,
                    ArticleSettings.ArticleMainImageMinRaito
                    );
        }
    }
}