using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankCard
    {
        private int _Balance;
        private string _CardType;
        private int _CardNumber;

        public BankCard() //Default väärtused...
        {
            _Balance = 0;
            _CardType = "Visa"; 
        }

        public BankCard(string CardType, int Balance)
        {
            _CardType = CardType;
            _Balance = Balance;
        }
        public void CardTypeGet()
        {
            GreenText("Card type: " + _CardType);
        }
        public void PrintBalance()
        {
            GreenText("Your card balance: " + _Balance + "$");
        }
        public void CardNumberGet()
        {
            GreenText("Card number: " + _CardNumber);
        }
        
        public void CardNumberSet()
        {
            Console.Clear();
            bool cor = false;
            while (cor == false)
            {
                CardTypeGet();
                Console.WriteLine("Insert 8 digits card number");
                int Number = OnlyInt(Console.ReadLine()); //"OnlyInt" Meetod kotrollid kontrollib kohe, kas string on arvulie väärtusega ja tagastab arvu. Kui pole ss tahastab ikkagi "0"
                if (Number.ToString().Length == 8)
                {
                    cor = true;
                    _CardNumber = Number;
                }
                else if (Number != 0)
                {
                    ErrorRed("Invalid value, the correct format is 8 digits!");
                }
            }
        }

        public void CardTypeSet(string CardType) //Muudab sissetuleva väärtusega kaarditüübi. Kindlad väärtused määratud "Main" while-loopis. 
        {
            _CardType = CardType;
            Console.WriteLine("Card type: " + _CardType);
        }

        public void AddMoney(int Money)
        {
            if (Money > 0)
            {
                Console.Clear();
                _Balance += Money;
            }
        }

        public void SubTMoney(int Money)
        {
            if (Money > 0 && _Balance >= Money)
            {
                Console.Clear();
                _Balance -= Money;
            }
            else if (_Balance < Money)
            {
                 ErrorRed("Cannot do this operation, not sufficient funds!");
            }
        }

        public int OnlyInt(string stringNumber) //Tegin endale string to int printeri. Ei leidnud süsteemi poolt loodud meetodit selleks. VB on olemas - tunnis küsin!
        {
            int num = 0;
            if (stringNumber.All(char.IsDigit) == true && stringNumber != "" && stringNumber.Length < 9)
            {
                num = Int32.Parse(stringNumber);  //Ainuke Int Väärtuse tekitaja. Kõik väärtused "stringis".
            }
            else if (stringNumber == "")
            {
                ErrorRed("Thanks for Nothing!"); //Vabandan väikese naljanumbri pärast! :)     Little EasterEgg Included!
            }
            else
            {
                ErrorRed("Input includes non-numberic characters!");
            }
            return num; //Kui String väärtus ei ole numbriline, siis väljund alati 0.
        }

        public void ErrorRed(string red) //Idee errorid kuvada punasena. Abiks oli: "https://stackoverflow.com/questions/17053359/change-string-color"
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(red);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void GreenText(string green) //Määratud väärtused kuvan rohelisena.
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(green);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
