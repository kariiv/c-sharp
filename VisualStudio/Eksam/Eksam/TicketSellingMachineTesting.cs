using System;
using NUnit.Framework;

namespace Eksam
{
    [TestFixture]
    class TicketSellingMachineTesting
    {
        /// <summary>
        /// TO GET TESTS TO WORK PLEASE SET _readFromFile to FALSE in the TicketSellingMachine class.
        /// </summary>
        private Ticket _ticket1;
        private Ticket _ticket2;
        private TicketSellingMachineEconomy _economy1;
        private TicketSellingMachineEconomy _economy2;
        private TicketSellingMachineEconomy _economy3;
        private TicketSellingMachineBusiness _business1;
        private TicketSellingMachineBusiness _business2;

        [SetUp]
        public void TestSetup()
        {
            _ticket1 = new Ticket();
            _ticket2 = new Ticket();
            _economy1 = new TicketSellingMachineEconomy("EATLLCSI5b", "2018.02.03");
            _economy2 = new TicketSellingMachineEconomy("EABERCSI2", "2018.04.12");
            _economy3 = new TicketSellingMachineEconomy("EABERCSI5", "2018.08.15");
            _business1 = new TicketSellingMachineBusiness("EABERCSI5", "2019.07.06"); //Business not available
            _business2 = new TicketSellingMachineBusiness("EABERCSI5b", "2018.02.16");
        }
        [Test]
        public void Economy_Pricing_Test()
        {
            _economy1.BaseSettings(120, 3);
            _economy1.SoldTickets.Add(_ticket1);
            _economy1.SoldTickets.Add(_ticket2);
            double expected = _economy1.Pricing(DateTime.Parse("2018.01.01"));
            Assert.That(expected, Is.EqualTo(233.91));
        }

        [Test]
        public void Economy_ApplyWeekdayRate_Saturday_Test()
        {
            double expected = _economy1.ApplyWeekdayRate(125.5);
            Assert.That(expected, Is.EqualTo(144.325));
        }

        [Test]
        public void Economy_ApplyWeekdayRate_Thursday_Test()
        {
            double expected = _economy2.ApplyWeekdayRate(150);
            Assert.That(expected, Is.EqualTo(150));
        }
        
        [Test]
        public void Economy_ApplyTimeRate_Over3Months_Test()
        {
            double expected = _economy2.ApplyTimeRate(100, DateTime.Parse("2018.01.08"));
            Assert.That(expected, Is.EqualTo(130));
        }

        [Test]
        public void Economy_ApplyTimeRate_Over7Months_Test()
        {
            double expected = _economy3.ApplyTimeRate(100, DateTime.Parse("2018.01.08"));
            Assert.That(expected, Is.EqualTo(100));
        }

        [Test]
        public void Economy_ApplyTimeRate_LessThanMonth_Test()
        {
            double expected = _economy2.ApplyTimeRate(100, DateTime.Parse("2018.04.08"));
            Assert.That(expected, Is.EqualTo(160));
        }

        [Test]
        public void Business_ApplyTimeRate_BusinessNotAvailable_0_Test()
        {
            double expected = _business1.ApplyTimeRate(600, DateTime.Parse("2019.06.16"));
            Assert.That(expected, Is.EqualTo(0));
        }

        [Test]
        public void Business_ApplyTimeRate_Over5Months_Test()
        {
            double expected = _business2.ApplyTimeRate(100, DateTime.Parse("2017.09.03"));
            Assert.That(expected, Is.EqualTo(110));
        }

        [Test]
        public void Economy_ApplyOccupancyRate_0_Test()
        {
            _economy1.NumberOfSeats = 10;
            double expected = _economy1.ApplyOccupancyRate(100);
            Assert.That(expected, Is.EqualTo(100));
        }

        [Test]
        public void Economy_ApplyOccupancyRate_50_Test()
        {
            _economy1.BaseSettings(100, 2);
            _economy1.SoldTickets.Add(_ticket1);
            double expected = _economy1.ApplyOccupancyRate(100);
            Assert.That(expected, Is.EqualTo(110));
        }

        [Test]
        public void Economy_ApplyOccupancyRate_67_Test()
        {
            _economy1.BaseSettings(100, 3);
            _economy1.SoldTickets.Add(_ticket1);
            _economy1.SoldTickets.Add(_ticket2);
            double expected = _economy1.ApplyOccupancyRate(100);
            Assert.That(expected, Is.EqualTo(113));
        }
        
        [Test]
        public void Business_ApplyOccupancyRate_50_Test()
        {
            _business2.BaseSettings(100, 2);
            _business2.SoldTickets.Add(_ticket1);
            double expected = _business2.ApplyOccupancyRate(400);
            Assert.That(expected, Is.EqualTo(480));
        }

        [Test]
        public void Business_ApplyOccupancyRate_30_Test()
        {
            _business2.BaseSettings(100, 1);
            _business2.SoldTickets.Add(_ticket1);
            double expected = _business2.ApplyOccupancyRate(100);
            Assert.That(expected, Is.EqualTo(134));
        }

        [Test]
        public void Economy_FreeSeats_Test()
        {
            _economy2.BaseSettings(120, 3);
            _economy2.SoldTickets.Add(_ticket1);
            _economy2.SoldTickets.Add(_ticket2);
            int expected = _economy2.FreeSeats();
            Assert.That(expected, Is.EqualTo(1));
        }

    }
}
