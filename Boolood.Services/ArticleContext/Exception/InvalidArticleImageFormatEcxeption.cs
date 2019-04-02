using Boolood.Framework.Exception;
using Boolood.Model.Constants;

namespace Boolood.Services.ArticleContext.Exception
{
    public class InvalidArticleImageFormatEcxeption : AppException
    {
        public InvalidArticleImageFormatEcxeption(params dynamic[] values) : base(values)
        {
        }

        public override string ReleventExceptionReourceKey()
        {
            return ExceptionResourceKeys.InvalidArticleImageFormatEcxeption;
        }
    }
}