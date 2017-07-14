﻿using System;
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

            // TODO MatthiasZ 14.07.2017: Add case for trivial second string.+
            if (firstString.IsNullOrEmpty())
            {
                combinedString = secondString;
            }
            else
            {
                combinedString = firstString + ", " + secondString;
            }

            return combinedString;
        }

        public static Boolean IsNullOrEmpty(this String str)
        {
            return str==null || str.Equals("");
        }
    }
}
