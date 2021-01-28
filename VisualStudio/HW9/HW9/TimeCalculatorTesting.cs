using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HW9
{
    [TestFixture]
    class TimeCalculatorTesting
    {
        TimeCalculator Time;
        [SetUp]
        public void TestSetup()
        {
            Time = new TimeCalculator();
        }

        [Test]
        public void TimeTest1()
        {
            DateTime Result = Time.FindTime(2);
            DateTime Expected = new DateTime(2000, 1, 1 , 2, 0, 0);
            Assert.AreEqual(Expected, Result);
        }

        [Test]
        public void TimeTest2()
        {
            DateTime Result = Time.FindTime(-1);
            DateTime Expected = new DateTime(1999, 12, 31, 23, 0, 0);
            Assert.AreEqual(Expected, Result);
        }

        [Test]
        public void TimeTest3()
        {
            DateTime Result = Time.FindTime(25.5);
            DateTime Expected = new DateTime(2000, 1, 2, 1, 30, 0);
            Assert.AreEqual(Expected, Result);
        }

        [Test]
        public void TimeTest4()
        {
            DateTime Result = Time.FindTime(-26);
            DateTime Expected = new DateTime(1999, 12, 30, 22, 0, 0);
            Assert.AreEqual(Expected, Result);
        }

        [Test]
        public void TimeTestDayAdd1()
        {
            DateTime Result = Time.FindTimeDay(12);
            DateTime Expected = new DateTime(2000, 1, 13, 0, 0, 0);
            Assert.AreEqual(Expected, Result);
        }
        [Test]
        public void TimeTestDayAdd2()
        {
            DateTime Result = Time.FindTimeDay(2.5);
            DateTime Expected = new DateTime(2000, 1, 3, 12, 0, 0);
            Assert.AreEqual(Expected, Result);
        }
        [Test]
        public void TimeTestDaySub1()
        {
            DateTime Result = Time.FindTimeDay(-2);
            DateTime Expected = new DateTime(1999, 12, 30, 0, 0, 0);
            Assert.AreEqual(Expected, Result);
        }
        [Test]
        public void TimeTestDaySub2()
        {
            DateTime Result = Time.FindTimeDay(-2.5);
            DateTime Expected = new DateTime(1999, 12, 29, 12, 0, 0);
            Assert.AreEqual(Expected, Result);
        }

        [Test]
        public void MinutesFromDateTime1()
        {
            DateTime Expected = new DateTime(2005, 1, 9, 5, 24, 0);
            string Result = Time.FindMinutesFromInput(Expected);
            Assert.AreEqual("24", Result);
        }

        [Test]
        public void MinutesFromDateTime2()
        {
            DateTime Expected = new DateTime(1999, 12, 29, 12, 34, 0);
            string Result = Time.FindMinutesFromInput(Expected);
            Assert.AreEqual("34", Result);
        }

        [Test]
        public void MinutesFromDateTime3()
        {
            DateTime Expected = new DateTime(2015, 2, 11, 18, 46, 0);
            string Result = Time.FindMinutesFromInput(Expected);
            Assert.AreEqual("46", Result);
        }
    }
}
