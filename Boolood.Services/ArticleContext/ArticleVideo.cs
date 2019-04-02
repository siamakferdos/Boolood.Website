using Boolood.Framework.Pattern;
using Microsoft.AspNetCore.Http;

namespace Boolood.Services.ArticleContext
{
    public class ArticleVideo : ArticleFile
    {
        public override void CheckFileRules() {/*CHECK STH*/ }

        public void CheckVideoRules() {/*CHECK STH*/ }

        public ArticleVideo(CommandsHandler validator, CommandsHandler saver, IFormFile file, string path)
            : base(validator, saver, file, path)
        {
            validator.AddCommand(CheckVideoRules);
        }
    }
}