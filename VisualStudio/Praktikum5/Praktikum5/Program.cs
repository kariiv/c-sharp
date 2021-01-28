using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Praktikum5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome:");
            Palin(Console.ReadLine());
            Ules4();

            Console.WriteLine("Insert temperature");
            FahCel(Console.ReadLine());

            string Number = CarNumber(Console.ReadLine());
            Console.WriteLine("CarNumber: " + Number);
            Soup();
        }

        static void Soup()
        {
            double room = 20;
            double soup = 60;

            if (room >= soup)
            {
                Console.WriteLine("Soup is already room temp!");
            }
            Console.WriteLine("SoupTempBefore: {0}\n",soup);
            for (int i = 0; i < 7; i++)
            {
                if (room < soup)
                {
                    soup = soup - ((soup-room) * 0.13);
                    Console.WriteLine("SoupTempMinut: " + soup);
                }
            }
            Console.ReadLine();
        }

        static string CarNumber(string regNum)
        {
            string numbers = null;
            string letters = null;

            bool run = true;
            while (run == true)
            {
                if (regNum.Length == 6)
                {
                    numbers = regNum.Substring(0, 3);
                    letters = regNum.Substring(3, 3);
                    char[] noChar = new char[4] { 'ä', 'ö', 'ü', 'õ' };

                    if (numbers.All(char.IsDigit) == true && letters.IndexOfAny(noChar) == -1 && letters.All(char.IsLetter) == true)
                    {
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid! Please insert RegNumber!");
                        regNum = Console.ReadLine();
                    }
                }
            }
            return regNum;
        }

        static void FahCel(string inP)
        {
            string Temp = null;
            if (inP[inP.Length - 1] == 'F' || inP[inP.Length - 1] == 'f')
            {
                string tempNumber = inP.Substring(0, inP.Length - 1);
                if (tempNumber.All(char.IsDigit) == true)
                {
                    Temp = ((Double.Parse(tempNumber) - 32) * 5/9).ToString() + "C";
                    Console.WriteLine("Converted Temp: " + Temp);
                }
            }
            else if (inP[inP.Length - 1] == 'C' || inP[inP.Length - 1] == 'c')
            {
                string tempNumber = inP.Substring(0, inP.Length - 1);
                if (tempNumber.All(char.IsDigit) == true)
                {
                    Temp = (Double.Parse(tempNumber) * 9/5 +32).ToString() + "F";
                    Console.WriteLine("Converted Temp: " + Temp);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }

        static void Ules4()
        {
            string fileRead = @"Read.txt";
            string fileWrite = @"Write.txt";

            List<string> ReadList = new List<string>();
            using (StreamReader reader = new StreamReader(fileRead))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    ReadList.Add(line);
                }
            }

            Random rnd = new Random();

            for (int i=0; i < ReadList.Count(); i++)
            {
                string e = ReadList[i];
                
                if (e.Length < 6 && e.Contains("x"))
                {
                    while (e.Length < 6)
                    {
                        e += 0;
                    }
                    ReadList[i] = e;
                }
                else if (e.Length < 6)
                {
                    while (e.Length < 6)
                    {
                        e += rnd.Next(9);
                    }
                    ReadList[i] = e;
                }
                else
                {
                    Console.WriteLine("Word length is " + e.Length);
                }
            }

            using (StreamWriter writer = new StreamWriter(fileWrite, true))
            {
                foreach (string e in ReadList)
                {
                    Console.WriteLine(e);
                    writer.WriteLine(e);
                }
            }
            Console.ReadLine();
        }

        static void Palin(string word)
        {
            string back = null;
            for (int i = word.Length-1; i >= 0 ;i--)
            {
                back += word[i];
            }

            if (word == back)
            {
                Console.WriteLine("Word is a palindrome!");
            }
            else
            {
                Console.WriteLine("Word is not a palindrome!");
            }
        }


    }
}
