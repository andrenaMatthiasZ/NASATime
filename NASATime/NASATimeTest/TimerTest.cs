using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASATime;

namespace NASATimeTest
{
    [TestClass]
    public class TimerTest
    {
        private Timer timer;

        [ClassInitialize]
        public void SetUp()
        {
            timer = new Timer();
        }

        [TestMethod]
        public void DefaultReturnsTenToZeroCountDown()
        {            
            Assert.AreEqual("10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0", timer.countDown());
        }

        [TestMethod]
        public void negativeStartReturnsZeroCountDown()
        {
            timer.setStartingValue(-1);

            Assert.AreEqual("0", timer.countDown());
        }

        [TestMethod]
        public void NonDefaultStartReturnsRightCountDown()
        {
            timer.setStartingValue(3);

            Assert.AreEqual("3, 2, 1, 0", timer.countDown());
        }
    }
}
