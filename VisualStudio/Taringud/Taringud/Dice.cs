using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taringud
{
    class Dice
    {
        Random rnd = new Random();
        public void DrawFrame()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int rida = 0; rida < 7; rida++)
            {
                //Kast
                for (int car = 0; car < 7; car++)//ridaSisu
                {
                    if (rida == 0 || rida == 6)
                        Console.Write("*");
                    else
                    {
                        if (car == 0 || car == 6)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DrawRandomNumber()
        {
            int number = rnd.Next(1,7);
            Console.CursorTop = 2;
            Console.CursorLeft = 2;

            if (number == 1)
                PrintOne();
            else if (number == 2)
                PrintTwo();
            else if (number == 3)
                PrintThree();
            else if (number == 4)
                PrintFour();
            else if (number == 5)
                PrintFive();
            else if (number == 6)
                PrintSix();
        }

        public void PrintOne()
        {
            for (int rida = 0; rida < 3; rida++)
            {
                for (int car = 0; car < 3; car++)
                {
                    if (rida == 1 && car == 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
                Console.CursorLeft = 2;
            }
        }
        public void PrintSix()
        {
            for (int rida = 0; rida < 3; rida++)
            {
                for (int car = 0; car < 3; car++)
                {
                    if (car != 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
                Console.CursorLeft = 2;
            }
        }
        public void PrintTwo()
        {
            for (int rida = 0; rida < 3; rida++)
            {
                for (int car = 0; car < 3; car++)
                {
                    if (rida == 1 && car != 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
                Console.CursorLeft = 2;
            }
        }
        public void PrintThree()
        {
            for (int rida = 0; rida < 3; rida++)
            {
                for (int car = 0; car < 3; car++)
                {
                    if (rida == car)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
                Console.CursorLeft = 2;
            }
        }
        public void PrintFour()
        {
            for (int rida = 0; rida < 3; rida++)
            {
                for (int car = 0; car < 3; car++)
                {
                    if (car != 1 && rida != 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
                Console.CursorLeft = 2;
            }
        }
        public void PrintFive()
        {
            for (int rida = 0; rida < 3; rida++)
            {
                for (int car = 0; car < 3; car++)
                {
                    if (car != 1 && rida != 1 || rida == 1 && car ==1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
                Console.CursorLeft = 2;
            }
        }
    }
}
