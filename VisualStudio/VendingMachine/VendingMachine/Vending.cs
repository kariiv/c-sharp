using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Vending
    {
        private int DepositedAmount;

        public Vending()
        {
            DepositedAmount = 0;
        }

        public void DepositCoin(int coinAmount)
        {
            DepositedAmount += coinAmount;
        }

        public int GetDeposit()
        {
            return DepositedAmount;
        }

        public void GetDrink()
        {
            if (DepositedAmount >= 75)
            {
                Console.WriteLine("Take Your Drink!");
                DepositedAmount -= 75;
                Console.WriteLine("Your change is " + DepositedAmount + " cents");
            }
            else if (DepositedAmount < 75)
            {
                Console.WriteLine("Insert more coins!");
            }
        }

        public void GetRefund()
        {
            Console.WriteLine("You were refunded " + DepositedAmount + " sents");
            DepositedAmount = 0;
        }

    }
}
