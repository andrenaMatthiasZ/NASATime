using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASATime;

namespace NASATimeTest
{
    [TestClass]
    public class TimerTest
    {
        [TestMethod]
        public void DefaultReturnsTenToZero()
        {
            Timer timer = new Timer();

            Assert.AreEqual("10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0", timer.countDown());
        }
    }
}
