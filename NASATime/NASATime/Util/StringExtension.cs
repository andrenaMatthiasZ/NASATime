using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace NASATime.Util
{
    public static class StringExtension
    {
        private const string COMMA_SEPARATOR = ", ";

        public static String CombineWithComma( this String firstString ,String secondString)
        {
            String combinedString = firstString;
            
            if (firstString.IsNullOrEmpty())
            {
                combinedString = secondString;
            }
            else if (secondString.IsNullOrEmpty())
            {
                combinedString = firstString;
            } else
            {
                combinedString = firstString + COMMA_SEPARATOR + secondString;
            }

            return combinedString;
        }

        public static Boolean IsNullOrEmpty(this String str)
        {
            return str==null || str.Equals("");
        }
    }
}
