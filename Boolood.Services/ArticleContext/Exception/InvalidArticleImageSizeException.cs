﻿using Boolood.Framework.Exception;
using Boolood.Model.Constants;

namespace Boolood.Services.ArticleContext.Exception
{
    public class InvalidArticleImageSizeException : AppException
    {
        public InvalidArticleImageSizeException(params dynamic[] values) : base(values)
        {
        }

        public override string ReleventExceptionReourceKey()
        {
            return ExceptionResourceKeys.InvalidArticleImageSizeException;
        }
    }
}