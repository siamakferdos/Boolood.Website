using System.IO;
using Boolood.Framework.Pattern;
using Boolood.Services.ArticleContext.Exception;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext.Validator
{
    public abstract class ArticleImageValidator : ArticleFileValidator
    {
        public void CheckImageRules()
        {
            var extension = Path.GetExtension((string) FormForm.FileName);
            if (extension.Length != 4 || !".jpg-.png".Contains(extension))
                throw new InvalidArticleImageFormatEcxeption(FormForm.FileName);
        }

        protected ArticleImageValidator(CommandsHandler validator, IFormFile file)
            : base(validator, file)
        {
            validator.AddCommand(CheckImageRules);
        }
    }
}