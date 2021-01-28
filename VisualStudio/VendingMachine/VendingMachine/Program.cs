using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drink - 75 sents\nCoins: 10; 20; 50; 100\nD - Get Drink!\nx - exit!");
            Vending inPut = new Vending();
            int r = 0;
            while (r == 0)
            {
                string inp = Console.ReadLine();
                if (inp == "D")
                {
                    inPut.GetDrink();
                }
                else if (inp == "10")
                {
                    inPut.DepositCoin(10);
                    Console.WriteLine("Your balance: " + inPut.GetDeposit());
                }
                else if (inp == "20")
                {
                    inPut.DepositCoin(20);
                    Console.WriteLine("Your balance: " + inPut.GetDeposit());
                }
                else if (inp == "50")
                {
                    inPut.DepositCoin(50);
                    Console.WriteLine("Your balance: " + inPut.GetDeposit());
                }
                else if (inp == "100")
                {
                    inPut.DepositCoin(100);
                    Console.WriteLine("Your balance: " + inPut.GetDeposit());
                }
                else if (inp == "x")
                {
                    r++;
                }
            }

            inPut.GetRefund();

            Console.ReadLine();
        }
    }
}
