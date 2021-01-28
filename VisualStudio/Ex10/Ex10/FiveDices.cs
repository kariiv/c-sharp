using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex10
{
    class FiveDices
    {
        Random rnd = new Random();
        List<int> numbers = new List<int>();
        List<int> allNumbers = new List<int>();
        public void DrawEmptyDices()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            int column = 0;
            int row = 0;
            int index = 0;
            while (column <= 6)
            {
                while (index < 50)
                {
                    Console.CursorLeft = index;
                    Console.CursorTop = column;
                    for (row = 0; row <= 6; row++)
                    {
                        if (((column == 0 || column == 6) && (row >= 0 && row <= 6)) || ((row == 0 || row == 6) && (column >= 0 && column <= 6)))
                            Console.Write("*");
                        else
                            Console.Write(" ");
                        index++;

                    }
                    index += 3;
                }
                index = 0;

                column++;
            }


            Console.Write("\n");
        }

        public void DrawNumbers()
        {
            int x = 2;

            for (int i = 0; i < 5; i++)
            {

                int nr = rnd.Next(1, 7);
                numbers.Add(nr);
                DrawNumber(x, nr);
                x += 10;
            }
            allNumbers.AddRange(numbers);
        }

        public void WriteNumbers()
        {
            numbers.ForEach(s => Console.Write(s + " "));
            numbers.Clear();
        }

        public void WriteAllNumbers()
        {
            allNumbers.ForEach(s => Console.Write(s + " "));
        }

        public void DrawNumber(int x, int number)
        {
            Console.CursorLeft = x;
            Console.CursorTop = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (number)
                    {
                        case 1:
                            DrawOne(i, j);
                            break;
                        case 2:
                            DrawTwo(i, j);
                            break;
                        case 3:
                            DrawThree(i, j);
                            break;
                        case 4:
                            DrawFour(i, j);
                            break;
                        case 5:
                            DrawFive(i, j);
                            break;
                        case 6:
                            DrawSix(i, j);
                            break;
                        default: break;
                    }
                }

                Console.Write("\n");
                Console.CursorLeft = x;
                Thread.Sleep(300); //Helps to write one mark at a time
            }
        }

        public void DrawSix(int i, int j)
        {
            if (j == 0 || j == 2)
                Console.Write("*");
            else
                Console.Write(" ");
        }

        public void DrawOne(int i, int j)
        {
            if (i == 1 && j == 1)
                Console.Write("*");
            else
                Console.Write(" ");
        }

        public void DrawTwo(int i, int j)
        {
            if (i == 1 && ((j == 2) || (j == 0)))
                Console.Write("*");
            else
                Console.Write(" ");
        }

        public void DrawThree(int i, int j)
        {
            if (i == 1)
                Console.Write("*");
            else
                Console.Write(" ");
        }

        public void DrawFour(int i, int j)
        {
            if (i != 1 && j != 1)
                Console.Write("*");
            else
                Console.Write(" ");
        }

        public void DrawFive(int i, int j)
        {
            if ((i != 1 && j != 1) || (i == 1 && j == 1))
                Console.Write("*");
            else
                Console.Write(" ");
        }
    }
}
