using Boolood.Framework.Pattern;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext.Validator
{
    public abstract class ArticleFileValidator
    {
        protected IFormFile FormForm;
        protected string FileFullPath;
        public abstract void CheckFileRules();

        protected ArticleFileValidator(CommandsHandler validator, IFormFile file)
        {
            FormForm = file;
            validator.AddCommand(CheckFileRules);
        }
    }
}