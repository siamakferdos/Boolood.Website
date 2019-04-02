using Boolood.Framework.Exception;
using Boolood.Model.Constants;

namespace Boolood.Services.ArticleContext.Exception
{
    public class InvalidArticleImageRaitoException : AppException
    {
        public InvalidArticleImageRaitoException(params dynamic[] values) : base(values)
        {
        }

        public override string ReleventExceptionReourceKey()
        {
            return ExceptionResourceKeys.InvalidArticleImageRaitoException;
        }
    }
}