using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taringud
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            string enter = "";
            while (enter != "x" || enter != "X")
            {
                Console.Clear();
                dice.DrawFrame();
                dice.DrawRandomNumber();
                Console.WriteLine("\n\nRoll Again? To exit, enter X");
                enter = Console.ReadLine();
            }
            
            Console.ReadLine();
        }
    }
}
