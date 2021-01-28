using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c = IsIt("Metskass", "Mets");
            Console.WriteLine(c);

            bool d = IsIt("Metskass", "Karu");
            Console.WriteLine(d);

            PrintString("Test");
            PrintSumOfNumbers(15, 47);
            int a = GetSumOfNumbers(2, 4);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        static void PrintString(string stringToPrint)
        {
            Console.WriteLine(stringToPrint);
        }

        static void PrintSumOfNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int GetSumOfNumbers(int a, int b)
        {
            return a + b;
        }

        static bool IsIt(string a, string b)
        {
            bool c = a.Contains(b);
            return c;
        }
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = GetList();
            /*
            Console.WriteLine("List:");
            int addAll = 0;
            foreach (int name in myList)
            {
                Console.WriteLine(name);
                addAll += name;
            }
            Console.WriteLine("\n" + addAll);

            Console.WriteLine("\nAdded 2 List:");


            int addedAll = 0;
            foreach (int name in myList)
            {
                Console.WriteLine(name + 2);
                addedAll += name + 2;
            }
            Console.WriteLine("\n" + addedAll);
             */
            /*
           for (int n = 0; n < myList.Count; n++)
           {
               Console.WriteLine(myList[n]);
           }
           */
            /*
            List<int> hugeNumbers = new List<int>();


            for (int n = 0; n < 100; n++)
            {
                hugeNumbers.Add(n);
                Console.WriteLine("Added: " + n + " List lenght: " + hugeNumbers.Count);
            }
            */
            /*
            Console.WriteLine("Please enter word with 4 letter in it!");
            string l = Console.ReadLine();

            while (l.Length == 4)
            {
                Console.WriteLine("Incorrect!");
                l = Console.ReadLine();
            }
            */
            int[] ArrayInts = new int[10];

            ArrayInts[5] = 9;

            foreach (int a in ArrayInts)
            {
                Console.WriteLine(a);
            }

            for(int f = 0; f < ArrayInts.Length; f++)
            {
                ArrayInts[f] = f;
            }

            foreach (int a in ArrayInts)
            {
                Console.WriteLine(a);
            }


            Console.ReadLine();

        }

        static List<int> GetList()
        {

            List<int> listOfNumbers = new List<int>();
            listOfNumbers.Add(2);
            listOfNumbers.Add(1);
            listOfNumbers.Add(3);
            listOfNumbers.Add(5);
            listOfNumbers.Add(7);

            return listOfNumbers;
        }

    }
}
