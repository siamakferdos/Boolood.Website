using Boolood.Framework.Pattern;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext
{
    public abstract class ArticleFile
    {
        protected IFormFile FormForm;
        protected string FileFullPath;
        public abstract void CheckFileRules();

        public void SaveFile()
        {

        }

        protected ArticleFile(CommandsHandler validator, CommandsHandler saver, IFormFile file, string path)
        {
            FormForm = file;
            FileFullPath = path;
            validator.AddCommand(CheckFileRules);
            saver.AddCommand(SaveFile);
        }
    }
}