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
        private const string NON_TRIVIAL_FIRST_STRING = "text1";
        private const string NON_TRIVIAL_SECOND_STRING = "test2";
        String firstString;
        String secondString;

        [TestMethod()]
        public void TwoNonTrivialStringsGetAdded()
        {
            firstString = NON_TRIVIAL_FIRST_STRING;
            secondString = NON_TRIVIAL_SECOND_STRING;
            Assert.AreEqual(firstString + ", " + secondString, firstString.AddWithCommaIfFirstStringIsNonTrivial(secondString));
        }

        [TestMethod()]
        public void FirstStringTrivialReturnsSecond()
        {
            firstString = "";
            secondString = NON_TRIVIAL_SECOND_STRING;
            Assert.AreEqual(secondString, firstString.AddWithCommaIfFirstStringIsNonTrivial(secondString));
        }

        [TestMethod()]
        public void SecondStringTrivialReturnsFirst()
        {
            firstString = NON_TRIVIAL_FIRST_STRING;
            secondString = "";
            Assert.AreEqual(secondString, firstString.AddWithCommaIfFirstStringIsNonTrivial(secondString));
        }




    }
}