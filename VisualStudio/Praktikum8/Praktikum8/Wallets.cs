using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum8
{

    class Wallet
    {
        private List<Money> _moneyInWallet = new List<Money>();

        public Wallet(Money money)
        {
            _moneyInWallet.Add(money);
        }

        public Money FindMoney(string currency)
        {
            foreach (Money m in _moneyInWallet)
                if (m.Contains.Equals(currency))
                    return m;
            return null;
        }

        public  MoneyAddToWallet()
        {


        }

        public bool AreEqual(Wallet wallet)
        {
            if (wallet._moneyInWallet.Count == _moneyInWallet.Count)
            {
                foreach (Money m in _moneyInWallet)
                {
                    if (wallet.FindMoney(m.Currency) != null)
                        return false;
                }
                return true;
            }

            return false;

            

        }



    }
}
