using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Praktikum8
{
    [TestFixture] // Testing class
    public class CalcTest
    {
        Calculator Calc;

        [SetUp]
        public void TestSetup()
        {
            Calc = new Calculator();
        }

        [Test]
        public void SubstractInt()
        {
            int expectedResult = Calc.Substract(9, 2);
            Assert.That(expectedResult, Is.EqualTo(7));
        }
        [Test]
        public void SubstractDouble()
        {
            double expectedResult = Calc.Substract(3, 1.5);
            Assert.That(expectedResult, Is.EqualTo(1.5));
        }
        [Test]
        public void MultiplyInt()
        {
            int expectedResult = Calc.Multiply(3, 2);
            Assert.That(expectedResult, Is.EqualTo(6));
        }
        [Test]
        public void MultiplyDouble()
        {
            double expectedResult = Calc.Multiply(3, 1.5);
            Assert.That(expectedResult, Is.EqualTo(4.5));
        }
        [Test]
        public void Multiply3Int()
        {
            int expectedResult = Calc.Multiply3(3, 2, 4);
            Assert.That(expectedResult, Is.EqualTo(24));
        }
        [Test]
        public void SquereInt()
        {
            int expectedResult = Calc.Squere(2);
            Assert.That(expectedResult, Is.EqualTo(4));
        }
    }
}
