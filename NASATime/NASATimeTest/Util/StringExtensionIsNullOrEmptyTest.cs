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
    public class StringExtensionIsNullOrEmptyTest
    {
        private String str;

        [TestMethod()]
        public void EmptyGivesTrue()
        {
            str = "";
            Assert.IsTrue(str.IsNullOrEmpty());
        }

        [TestMethod()]
        public void  NullGivesTrue()
        {
            str = null;
            Assert.IsTrue(str.IsNullOrEmpty());
        }



    }
}