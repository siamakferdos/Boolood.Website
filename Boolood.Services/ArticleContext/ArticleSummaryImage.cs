using Boolood.Framework.Pattern;
using Boolood.Model.Settings;
using Boolood.Services.ArticleContext.Exception;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext
{
    public class ArticleSummaryImage : ArticleImage
    {
        public ArticleSummaryImage(CommandsHandler validator, CommandsHandler saver, IFormFile file, string path)
            : base(validator, saver, file, path)
        {
            validator.AddCommand(CheckImageDimensions);
        }

        public override void CheckFileRules()
        {
            if (FormForm.Length > ArticleSettings.ArticleSummaryImageMaxBytes)
                throw new InvalidArticleImageSizeException(
                    FormForm.FileName, ArticleSettings.ArticleSummaryImageMaxBytes);
        }

        public void CheckImageDimensions() { }
    }
}