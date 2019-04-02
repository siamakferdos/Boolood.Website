using System;
using System.Collections.Generic;
using System.Text;

namespace Boolood.Framework.Exception
{
    public abstract class AppException: ApplicationException
    {
        private string _message = "";
        private dynamic[] _values;

        protected AppException(params dynamic[] values)
        {
            _values = values;
        }

        public abstract string ReleventExceptionReourceKey();
    }
}
