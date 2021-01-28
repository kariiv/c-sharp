using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3
{
    class TestingClass
    {
        static void Main(string[] args)
        {
            Person per1 = new Person();
            per1.SetName("Kauri Riivik");
            per1.SetAge(Console.ReadLine());
            Console.WriteLine(per1.GetName() + " " + per1.GetAge());

            Person per2 = new Person();
            per2.SetAge(Console.ReadLine());
            Console.WriteLine(per2.GetName() + " " + per2.GetAge());

            Person per3 = new Person("John Depp ", 56);
            Console.WriteLine(per3.GetName() + per3.GetAge());

            Person per4 = new Person();
            Console.WriteLine(per4.GetName() + " " +  per4.GetAge());

            Console.ReadLine();
            
        }
    }
}