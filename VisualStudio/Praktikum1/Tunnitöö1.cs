using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string StringList = "Please Enter Your Name";
            string name;
            string age;

            string math1;
            string math2;

            string input1;
            string input2;


            Console.WriteLine("Hello World! \n" + StringList);
            name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Age");
            age = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hei " + name + "!" + "\n" + "Your Age: " + age);
            Console.WriteLine("Palun kirjuta kaks arvu");

            math1 = Console.ReadLine();

            double intMath1 = Double.Parse(math1);  //input to Int

            math2 = Console.ReadLine();
            double intMath2 = Double.Parse(math2);  //input to Int

            Console.Clear();


            Console.WriteLine("Welcome to IQ Test! \n\nMõned Tüütud tehted!");
            Console.WriteLine("Nüüd mis on nende summa?");

            input1 = Console.ReadLine();

            double sum1 = intMath1 + intMath2;


            Console.Clear();
            Console.WriteLine("Nüüd mis on nende korrutis?");
            input2 = Console.ReadLine();

            double sum2 = intMath1 * intMath2;
            
        

            Console.WriteLine("Liitmine:\nSinu Vastus:\n" + input1 + "\nTegelik:\n" + sum1); //liitmine
            Console.WriteLine("\nKorrutamine:\nSinu Vastus:\n" + input2 + "\nTegelik:\n" + sum2); //korrutamin

            Console.ReadLine();

        }
    }
}