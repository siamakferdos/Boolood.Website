using System;
using Boolood.Framework.Exception;
using Boolood.Model.Constants;

namespace Boolood.Services.ArticleContext.Exception
{
    public class ArticleBodyInvalidImageCountException : AppException
    {
        public ArticleBodyInvalidImageCountException(params dynamic[] values) : base(values)
        {
        }

        public override string ReleventExceptionReourceKey()
        {
            return ExceptionResourceKeys.ArticleBodyInvalidImageCountException;
        }
    }
}