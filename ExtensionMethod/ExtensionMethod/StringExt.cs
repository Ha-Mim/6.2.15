using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class  StringExt
    {
        public static string GetFirstTwoChars(this string aString)
        {
            return aString.ToCharArray(0, 2).ToString();
        }
    }
}
