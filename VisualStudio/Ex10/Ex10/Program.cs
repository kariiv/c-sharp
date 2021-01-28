using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {

            Dice dice = new Dice();
            dice.DrawDice();
            dice.DrawRandomNumber();

            string input = "";
            while (input != "n")
            {
                Console.CursorTop = 10;
                Console.CursorLeft = 0;
                Console.WriteLine("Do you want to roll again? enter 'n' " +
                    "for exiting and 'enter' for rolling again");
                input = Console.ReadLine();
                dice.DrawRandomNumber();
            }
            Console.CursorTop = 11;
            Console.CursorLeft = 0;
            Console.WriteLine("Bye!");



           





          
            Console.ReadLine();
        }

    }
}
