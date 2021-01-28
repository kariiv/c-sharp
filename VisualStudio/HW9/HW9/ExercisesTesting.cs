using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HW9
{
    [TestFixture]
    class ExercisesTesting
    {
        Exercises Exes;

        [SetUp]
        public void TestSetup()
        {
            Exes = new Exercises();
        }

        [Test]
        public void TwoString_Test1()
        {
            string testResult = Exes.AddsTwoStrings("Lol","oloo");
            Assert.That(testResult, Is.EqualTo("Lololoo"));
        }
        [Test]
        public void TwoString_Test2()
        {
            string testResult = Exes.AddsTwoStrings("LHa  ", "ju");
            Assert.That(testResult, Is.EqualTo("LHa  ju"));
        }
        [Test]
        public void TwoString_Test3()
        {
            string testResult = Exes.AddsTwoStrings(" Shi-", "Shu ");
            Assert.That(testResult, Is.EqualTo(" Shi-Shu "));
        }
        [Test]
        public void TwoString_Test4()
        {
            string testResult = Exes.AddsTwoStrings("asd @", "fasd");
            Assert.That(testResult, Is.EqualTo("asd @fasd"));
        }


        [Test]
        public void Array_evens_Test()
        {
            Array TestArray = Exes.ArrayOfNumbers();
            int evens = 0;
            foreach (int e in TestArray)
            {
                if (e %2 == 0)
                    evens += 1;
            }
            int expected = 2;
            Assert.IsTrue(evens >= expected);
        }
        [Test]
        public void Array_odds_Test()
        {
            Array TestArray = Exes.ArrayOfNumbers();
            int odds = 0;
            foreach (int e in TestArray)
            {
                if (e % 2 == 1)
                    odds += 1;
            }
            int expected = 2;
            Assert.IsTrue(odds >= expected);
        }
        [Test]
        public void Array_5_Test()
        {
            Array TestArray = Exes.ArrayOfNumbers();
            int fives = 0;
            foreach (int e in TestArray)
            {
                if (e % 5 == 0)
                    fives += 1;
            }
            int expected = 1;
            Assert.IsTrue(fives >= expected);
        }
        [Test]
        public void Array_100_200_Test()
        {
            Array TestArray = Exes.ArrayOfNumbers();
            Assert.That(TestArray, Has.Exactly(2).InRange(100, 200));
        }
        [Test]
        public void Array_30_60_Test()
        {
            Array TestArray = Exes.ArrayOfNumbers();
            Assert.That(TestArray, Has.Exactly(2).InRange(30, 60));
        }
        [Test]
        public void Array_0_20_Test()
        {
            Array TestArray = Exes.ArrayOfNumbers();
            Assert.That(TestArray, Has.Exactly(2).InRange(0, 20));
        }


        [Test]
        public void BMI_Test1()
        {
            string testResult = Exes.BMI(70, 1.91);
            Assert.That(testResult, Is.EqualTo("Normal"));
        }
        [Test]
        public void BMI_Test2()
        {
            string testResult = Exes.BMI(65, 1.91);
            Assert.That(testResult, Is.EqualTo("Underweight"));
        }
        [Test]
        public void BMI_Test3()
        {
            string testResult = Exes.BMI(110, 1.7);
            Assert.That(testResult, Is.EqualTo("Obese"));
        }
        [Test]
        public void BMI_Test4()
        {
            string testResult = Exes.BMI(76, 1.6);
            Assert.That(testResult, Is.EqualTo("Overweight"));
        }
        [Test]
        public void BMI_Test5()
        {
            string testResult = Exes.BMI(59, 0);
            Assert.That(testResult, Is.EqualTo("Invalid"));
        }


        [Test]
        public void ReplaceSpace_Test1()
        {
            string testResult = Exes.ReplaceSpaces("What a Trolling   Master I   am!");
            Assert.That(testResult, Is.EqualTo("What*a*Trolling*Master*I*am!"));
        }
        [Test]
        public void ReplaceSpace_Test2()
        {
            string testResult = Exes.ReplaceSpaces("NoSpaceHereYouSee");
            Assert.That(testResult, Is.EqualTo("NoSpaceHereYouSee"));
        }
        [Test]
        public void ReplaceSpace_Test3()
        {
            string testResult = Exes.ReplaceSpaces("C a n  Y o u R       e a d  T h i s ?");
            Assert.That(testResult, Is.EqualTo("C*a*n*Y*o*u*R*e*a*d*T*h*i*s*?"));
        }
        [Test]
        public void ReplaceSpace_Test4()
        {
            string testResult = Exes.ReplaceSpaces("Last      NoW!         No                      Pee ! ");
            Assert.That(testResult, Is.EqualTo("Last*NoW!*No*Pee*!*"));
        }

    }

}
