using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASATime.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASATime.Util.Test
{
    [TestClass()]
    public class StringExtensionAddWithCommaIfFirstStringIsNonTrivialTest
    {
        [TestMethod()]
        public void TwoNonTrivialStringsGetAdded()
        {
            String firstString = "text1";
            String secondString = "test2";
            Assert.AreEqual(firstString + ", " + secondString, firstString.AddWithCommaIfFirstStringIsNonTrivial(secondString));
        }
    }
}