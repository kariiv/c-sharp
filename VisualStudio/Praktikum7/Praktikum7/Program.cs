using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Praktikum7
{
    class Program
    {
        static void Main(string[] args)
        {/*
            bool nonNumber = true;
            string readPath = null;*/

            List<int> a = new List<int>();
            try
            {
                Console.WriteLine(a[1]);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("List length is " + a.Count + " so indexes cant be bigger!");
                Console.WriteLine(ex.Message);
                
            }



            /*
            int a = 12;
            int b = 0;

            DevideZero(a, b);

            
            DoesFileExist(readPath);

            
            while (nonNumber)
            {
                try
                {
                    Console.WriteLine("Enter your age!");
                    int a = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Thanks!\nAge: " + a);
                    nonNumber = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Non-numering value, try again!");
                }
            }*/
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("GoodBye!");
            Thread.Sleep(2000);
        }

        static void DevideZero(int a, int b)
        {
            int result;
            try
            {
                result = a / b;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot devide with 0!, Will use 2 instead");
                result = a / 2;
            }
            Console.WriteLine("Result is " + result);
        }

        static void DoesFileExist(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {

                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.FileName + " was not found! Please check your file name!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("There is no file path!");
            }
        }
    }
}
