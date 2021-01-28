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
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("1.EX: Print Modified String! Write something..."); //1. Ülesanne 
            PrintModifiedString(Console.ReadLine());

            Console.WriteLine("\n2.EX: Upper Case Print! Write something...");  //2. Ülesanne
            PrintUpperCaseString(Console.ReadLine());

            Console.WriteLine("\n3.EX: Write 3 string...");  //3. Ülesanne
            SortingStrings(3);

            Console.WriteLine("\n4.EX: Write a number...");  //4. Ülesanne
            int randomSum = RandomArraySum(Int16.Parse(Console.ReadLine()));
            Console.WriteLine("\nSum of random numbers: " + randomSum);

            Console.WriteLine("\n5.EX: Guess my number!");   //5. Ülesanne
            int num = 8;
            int pre = Int16.Parse(Console.ReadLine());
            while (num != pre)
            {
                Console.WriteLine("Uups! Maybe not!");
                pre = Int16.Parse(Console.ReadLine());
            }
            Console.WriteLine("Great Job! Number " + num + " is correct!");

            Console.ReadLine();
        }

        static int RandomArraySum(int a) //4.Ül
        {
            int n;
            int[] ArrayInts = new int[a];
            Random rnd = new Random();
            for (n = 0; n < a; n++)
            {
                ArrayInts[n] = rnd.Next(100);
                Console.WriteLine(ArrayInts[n]);
            }
            int SUM = 0;
            for (int c = 0; c < ArrayInts.Length; c++)
            {
                SUM += ArrayInts[c];
            }
            return SUM;
        }

        static void SortingStrings(int o) //3.Ül
        {
            int i;
            List<string> listOfStrings = new List<string>();

            for (i = 0; i < o; i++)
            {
                listOfStrings.Add(Console.ReadLine());
            }
            listOfStrings.Sort();
            Console.WriteLine("\nSorted List:");
            foreach (string a in listOfStrings)
            {
                Console.WriteLine(a + " ");
            }
        }

        static void PrintModifiedString(string Print)  //1.Ül
        {
            int l = 0;
            string word = null;

            while ( l < Print.Length)
            {
                word += Print[l] + "a";
                l++;
            }
            Console.WriteLine(word);
        }

        static void PrintUpperCaseString(string cased) //2.Ül
        {
            int n;
            int count = 0;
            char ch;
            string word = null;
            string srt = cased;
            int l = srt.Length;
            Char[] arr = srt.ToCharArray(0, l);
            
            for (n = 0; n < l; n++)
            {
                ch = arr[n];
                if (Char.IsLower(ch))
                {
                    word += Char.ToUpper(ch);
                    count++;
                }
                else
                {
                    word += ch;
                }
            }

            if (count <= 0)
            {
                Console.WriteLine("Sorry, the word is already UpperCased!");
            }
            else
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(count + " changes made!");
        }

    }
}