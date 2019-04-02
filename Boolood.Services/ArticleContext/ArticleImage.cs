using System.IO;
using Boolood.Framework.Pattern;
using Boolood.Services.ArticleContext.Exception;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext
{
    public abstract class ArticleImage : ArticleFile
    {
        public void CheckImageRules()
        {
            var extension = Path.GetExtension(FormForm.FileName);
            if (extension.Length != 3 || !"jpg-png".Contains(extension))
                throw new InvalidArticleImageFormatEcxeption(FormForm.FileName);
        }

        protected ArticleImage(CommandsHandler validator, CommandsHandler saver, IFormFile file, string path)
            : base(validator, saver, file, path)
        {
            validator.AddCommand(CheckImageRules);
        }
    }
}