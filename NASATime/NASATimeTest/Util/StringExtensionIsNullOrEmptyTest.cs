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
        [TestMethod()]
        public void EmptyGivesTrue()
        {
            String str = "";
            Assert.IsTrue(str.IsNullOrEmpty());
        }

        [TestMethod()]
        public void  NullGivesTrue()
        {
            String str = null;
            Assert.IsTrue(str.IsNullOrEmpty());
        }

    }
}