using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = true;
            
            while (test)
            {
                Console.WriteLine("Sisesta kaal");
                double kaal = double.Parse(Console.ReadLine());
                Console.WriteLine("Sisesta pikkus");
                double pikkus = double.Parse(Console.ReadLine());
                Console.WriteLine("BMI: " + (kaal / (pikkus * pikkus)));
                Console.WriteLine("Sisesta ");
                if (Console.ReadLine() == "x")
                    test= false;
            }

        }
    }
}
