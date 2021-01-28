using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum8
{
    class Money
    {
        private int _money;
        private string _currency;

        public Money(int amount, string currency)
        {
            _money = amount;
            _currency = currency;
        }

        public bool AreEqual(Money money)
        {
            if (_money == money._money && _currency == money._currency)
                return true;
            else
                return false;
        }

        public Money AddMoney(Money money)
        {
            if (_currency == money._currency)
                return new Money(_money += money._money, money._currency);
            else
                return this;
        }
        public Money MultMoney(int i)
        {
                return new Money(_money * i, _currency);
        }
        public Money Negate()
        {
            return new Money(_money * -1, _currency);
        }
        public Money DevMoney(Money money)
        {
            if (_currency == money._currency)
                return new Money(_money -= money._money, money._currency);
            else
                return this;
        }
        public string PrintMoney()
        {
            string a = _money + _currency;
            return a;
        }
    }
}
