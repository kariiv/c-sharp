using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; //Disain ja mugavam vaade. 

            BankCard bankCard = new BankCard(); //Lisana alguses
            Console.WriteLine("Default card"); //
            bankCard.CardTypeGet();           //  
            bankCard.PrintBalance();         //
            Console.ReadLine();             //
            Console.Clear();               //Lisana alguses

            BankCard banking = new BankCard(); //Main Code Start!!!
            bool run1 = true;
            while (run1 == true)
            {
                Console.WriteLine("Set Your card type\n1 - Visa\n2 - Maestro");
                string input = Console.ReadLine();
                Console.Clear();
                if (input == "1" || input == "Visa")
                {
                    banking.CardTypeSet("Visa");
                    run1 = false;
                }
                else if (input == "2" || input == "Maestro")
                {
                    banking.CardTypeSet("Maestro");
                    run1 = false;
                }
                else
                {
                    banking.ErrorRed("Invalid input!");
                }
            }
            banking.CardNumberSet(); //Valed Sisendid Blokeeritakse Enda Tehtud Meetodi Abil.
            Console.Clear();

            bool run2 = true;
            while (run2 == true)
            {
                banking.CardTypeGet();
                banking.CardNumberGet();
                banking.PrintBalance();
                Console.WriteLine("Enter selection:\n1. Money in\n2. Money out\nX. Exit");
                string inP = Console.ReadLine();
                if (inP == "1")
                {
                    Console.WriteLine("Enter amount");
                    banking.AddMoney(banking.OnlyInt(Console.ReadLine())); //Valed Sisendid Blokeeritakse Enda Tehtud Meetodi Abil.
                }
                else if (inP == "2")
                {
                    Console.WriteLine("Enter amount");
                    banking.SubTMoney(banking.OnlyInt(Console.ReadLine())); //Valed Sisendid Blokeeritakse Enda Tehtud Meetodi Abil.
                }
                else if (inP == "x" || inP == "X")
                {
                    run2 = false; //ENDEX
                }
                else
                {
                    Console.Clear();
                    banking.ErrorRed("Invalid selection!");
                }
            }
        }
    }
}
