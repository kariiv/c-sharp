using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Praktikum8
{

    [TestFixture]
    class CarPlateTest
    {
        CarLicencePlate carCodes;
        [SetUp]
        public void TestSetup()
        {
            carCodes = new CarLicencePlate();
        }

        [Test]
        public void TestStringCode()
        {
            string val = "MLU";
            List<string> codes = carCodes.Generate4Code(val);

            Assert.That(codes.Count, Is.EqualTo(4));

            Assert.That(codes, Has.All.Contain(val));

            Assert.That(codes, Is.Unique);
        }

    }
}
