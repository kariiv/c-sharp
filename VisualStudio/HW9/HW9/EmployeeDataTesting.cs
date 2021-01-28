using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HW9
{
    [TestFixture]
    class EmployeeDataTesting
    {
        EmployeeData EmpData;

        [SetUp]
        public void TestSetup()
        {
            EmpData = new EmployeeData();
        }

        [Test]
        public void DomainRemovalTest1()
        {
            string name = EmpData.email[0];
            Assert.AreEqual(EmpData.RemoveDomain(name), "andre.griffin");
        }
        [Test]
        public void DomainRemovalTest2()
        {
            string name = EmpData.email[1];
            Assert.AreEqual(EmpData.RemoveDomain(name), "john.snow");
        }
        [Test]
        public void DomainRemovalTest3()
        {
            string name = EmpData.email[2];
            Assert.AreEqual(EmpData.RemoveDomain(name), "tim-allen.toomingas");
        }
        [Test]
        public void DomainRemovalTest4()
        {
            string name = EmpData.email[3];
            Assert.AreEqual(EmpData.RemoveDomain(name), "hei-hoo.chee_choo");
        }
        [Test]
        public void DomainRemovalTest5()
        {
            string name = EmpData.email[4];
            Assert.AreEqual(EmpData.RemoveDomain(name), "a.chin_chan");
        }

        
        [Test]
        public void FirstNameTest1()
        {
            Assert.AreEqual(EmpData.FirstNameCheckup("andre.griffin"), "Andre");
        }
        [Test]
        public void FirstNameTest2()
        {
            Assert.AreEqual(EmpData.FirstNameCheckup("john.snow"), "John");
        }
        [Test]
        public void FirstNameTest3()
        {
            Assert.AreEqual(EmpData.FirstNameCheckup("tim-allen.toomingas"), "Tim Allen");
        }
        [Test]
        public void FirstNameTest4()
        {
            Assert.AreEqual(EmpData.FirstNameCheckup("hei-hoo.chee_choo"), "Hei Hoo");
        }
        [Test]
        public void FirstNameTest5()
        {
            Assert.AreEqual(EmpData.FirstNameCheckup("a.chin_chan"), "Unknown");
        }


        [Test]
        public void LastNameTest1()
        {
            Assert.AreEqual(EmpData.LastNameCheckup("andre.griffin"), "Griffin");
        }
        [Test]
        public void LastNameTest2()
        {
            Assert.AreEqual(EmpData.LastNameCheckup("john.snow"), "Snow");
        }
        [Test]
        public void LastNameTest3()
        {
            Assert.AreEqual(EmpData.LastNameCheckup("tim-allen.toomingas"), "Toomingas");
        }
        [Test]
        public void LastNameTest4()
        {
            Assert.AreEqual(EmpData.LastNameCheckup("hei-hoo.chee_choo"), "Chee Choo");
        }
        [Test]
        public void LastNameTest5()
        {
            Assert.AreEqual(EmpData.LastNameCheckup("a.chin_chan"), "Chin Chan");
        }
        [Test]
        public void LastNameTest6()
        {
            Assert.AreEqual(EmpData.LastNameCheckup("martin.t"), "Unknown");
        }


        [Test]
        public void NameFromAdressTest1()
        {
            string address = EmpData.email[0];
            Assert.AreEqual(EmpData.NameFromAddress(address), "Andre Griffin");
        }
        [Test]
        public void NameFromAdressTest2()
        {
            string address = EmpData.email[1];
            Assert.AreEqual(EmpData.NameFromAddress(address), "John Snow");
        }
        [Test]
        public void NameFromAdressTest3()
        {
            string address = EmpData.email[2];
            Assert.AreEqual(EmpData.NameFromAddress(address), "Tim Allen Toomingas");
        }
        [Test]
        public void NameFromAdressTest4()
        {
            string address = EmpData.email[3];
            Assert.AreEqual(EmpData.NameFromAddress(address), "Hei Hoo Chee Choo");
        }
        [Test]
        public void NameFromAdressTest5()
        {
            string address = EmpData.email[4];
            Assert.AreEqual(EmpData.NameFromAddress(address), "Unknown Chin Chan");
        }


        [Test]
        public void ListOfNamesTest()
        {
            List<string> expected = new List<string>() {"Andre Griffin", "John Snow", "Tim Allen Toomingas", "Hei Hoo Chee Choo", "Unknown Chin Chan"};
            Assert.AreEqual(expected, EmpData.NameFromAddress());
        }



    }
}
