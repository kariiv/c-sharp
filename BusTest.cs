using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Ex09
{
    [TestFixture]
    class BusTest
    {
        Bus bus;
        [SetUp]
        public void TestSetup()
        {
            bus = new Bus(); //we create the object before test
        }

        [Test]
        public void Test60People_FindPeople()
        {
            bus.FindNumbers(60, 40);
            Assert.That(bus.GetNrOfPeople, Is.EqualTo(20));
        }

        [Test]
        public void Test60People_FindBusses()
        {
            bus.FindNumbers(60, 40);
            Assert.That(bus.GetNrOfBuses, Is.EqualTo(2));
        }

        [Test]
        public void Test80People_FindPeople()
        {
            bus.FindNumbers(80, 40);
            Assert.That(bus.GetNrOfPeople, Is.EqualTo(40));
        }

        [Test]
        public void Test80People_FindBuses()
        {
            bus.FindNumbers(80, 40);
            Assert.That(bus.GetNrOfBuses, Is.EqualTo(2));
        }

        [Test]
        public void Test20People_FindPeople()
        {
            bus.FindNumbers(20, 40);
            Assert.That(bus.GetNrOfPeople, Is.EqualTo(20));
        }

        [Test]
        public void Test20People_FindBusses()
        {
            bus.FindNumbers(20, 40);
            Assert.That(bus.GetNrOfBuses, Is.EqualTo(1));
        }

        [Test]
        public void Test40People_FindPeople()
        {
            bus.FindNumbers(40, 40);
            Assert.That(bus.GetNrOfPeople, Is.EqualTo(40));
        }

        [Test]
        public void Test40People_FindBuses()
        {
            bus.FindNumbers(40, 40);
            Assert.That(bus.GetNrOfBuses, Is.EqualTo(1));
        }
    }
}
