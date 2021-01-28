using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Dice
    {
        Random rnd = new Random();
        public void DrawDice()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if ((i == 0 || i == 6) || (j == 0 || j == 6))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.Write("\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DrawRandomNumber()
        {
            int number = rnd.Next(1, 7);

            Console.CursorLeft = 2;
            Console.CursorTop = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (number)
                    {
                        case 1:
                            DrawOne(i,j);
                            break;
                        case 2:
                            DrawTwo(i,j);
                            break;
                        case 3:
                            DrawThree(i,j);
                            break;
                        case 4:
                            DrawFour(i,j);
                            break;
                        case 5:
                            DrawFive(i,j);
                            break;
                        case 6:
                            DrawSix(i,j);
                            break;
                        default: break;
                    }
                }
                Console.Write("\n");
                Console.CursorLeft = 2;
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
