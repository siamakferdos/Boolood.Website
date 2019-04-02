using System;
using System.Collections.Generic;
using System.Text;
using Boolood.Resources;
using Boolood.Resources.Fa;

namespace Boolood.Utility
{
    public class StringUtility
    {
        public static string GetStringFromStringFormat(string str, params dynamic[] values)
        {
            var index = 0;
            while (values.Length > index && 
                str.IndexOf("{" + index + "}", StringComparison.Ordinal) > 0)
            {
                str.Replace("{" + index + "}", values[index]);
                index++;
            }
            return str;
        }
    }
}
