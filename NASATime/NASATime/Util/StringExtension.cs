using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASATime.Util
{
    public static class StringExtension
    {
        public static String AddWithCommaIfFirstStringIsNonTrivial( this String firstString ,String secondString)
        {
            String combinedString = firstString;

            if (firstString.Equals(null) || firstString.Equals(""))
            {
                combinedString = secondString;
            }
            else
            {
                combinedString = firstString + ", ";
            }

            return combinedString;
        }
    }
}
