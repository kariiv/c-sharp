using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IO_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Side();

            Console.ForegroundColor = ConsoleColor.Green;
            Random rnd = new Random();
            for(int o = 0; o<120; o++)
            {
                Console.Write(rnd.Next(2));
            }
            int rida = 1;
            int v1 = 2;
            int v2 = 22;
            int i = 28;
            int r = 34;
            int rc = 35;
            for (int l=0; l<121 && v1!=v2 ;l++)
            {
                if (v1 == l || (v1 + 1) == l || v2 == l || (v2 - 1) == l)
                {
                    RedChar(rnd.Next(2));
                }
                else if(i ==l || (i+1) == l)
                {
                    RedChar(rnd.Next(2));
                }
                else if (r == l || (r + 1) == l)
                {
                    RedChar(rnd.Next(2));
                }
                else if (rc == l || (rc+1)== l)
                {
                    RedChar(rnd.Next(2));
                }
                else
                {
                    Console.Write(rnd.Next(2));
                }
                if(l == 120)
                {
                    rida++;
                    l = 0;
                    v1++;
                    v2--;
                    if (rida ==2)
                    {
                        rc++;
                    }
                }
            }
            for (int o = 0; o < 120; o++)
            {
                Console.Write(rnd.Next(2));
            }

            Console.ReadLine();
        }
        
        static void Side()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random rnd = new Random();
            bool run = true;
            while (run)
            {
                Console.Write(rnd.Next(2));
                Thread.Sleep(1);
                bool subRun = true;
                if (rnd.Next(20) == 4)
                {
                    while (subRun)
                    {
                        int a = rnd.Next(8);
                        if (a < 7)
                        {
                            PrintYellow(rnd.Next(2));
                        }
                        else
                        {
                            PrintRed(rnd.Next(2));
                            subRun = false;
                        }
                    }
                }
            }
        }

        static void PrintRed(int text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void RedChar(int text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Green;
        }
        static void PrintYellow(int text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
