using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum6
{/*
    interface IDraw
    {
        void Draw();
        void SetHeight(int height);
    }
    
    class Shape : IDraw
    {
        internal string _color;
        internal int _height;
        public void SetHeight(int height)
        {
            _height = height;
            Console.WriteLine("Height was set to " + height);
        }

        public void Paint(string color)
        {
            _color = color;
            Console.WriteLine("Color was set to " + color);
        }
        public virtual void Draw()
        {
            Console.WriteLine("I'm a shape");
        }
        
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Circle");
        }
        public void CalculateArea(int a)
        {
            Console.WriteLine("Area of circle " + (2 * a^2));
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Triangle");
        }
        public void CalculateArea(int a, int b)
        {
            Console.WriteLine("Area of triangle" + (a*b));
        }
    }
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Square");
        }
        public void CalculateArea(int a)
        {
            Console.WriteLine("Area of square" + (a*a));
        }
    }*/

    interface ICard
    {
        void GetBalance();
        void SetBalance(int money);
        void Payment(int amount);
        void CardInfoPrint();
        void CloseCard();
        void OpenCard();
    }

    class DebitCard : ICard
    {
        internal int _balance;
        internal bool _cardOpened;
        internal string _cardType;

        public DebitCard(string cardType)
        {
            _balance = 0;
            _cardType = cardType;
            _cardOpened = true;
        }

        public void GetBalance()
        {
            Console.WriteLine("Balance: " + _balance);
        }
        public virtual void SetBalance(int money)
        {
            if (_cardOpened)
            {
                _balance = money;
            }
            else
            {
                Console.WriteLine("Sorry! The card is closed!");
            }
        }
        public virtual void Payment(int amount)
        {
            if (_cardOpened)
            {
                _balance += amount;
            }
            else
            {
                Console.WriteLine("Sorry! The card is closed!");
            }
        }
        public virtual void CardInfoPrint()
        {
            Console.WriteLine("\nCard type: {1}\nBalance: {0}",_balance, _cardType);
            if (_cardOpened)
            {
                Console.WriteLine("Card status: Opened");
            }
            else
            {
                Console.WriteLine("Card status: Closed");
            }

        }
        public void OpenCard()
        {
            _cardOpened = true;
        }
        public void CloseCard()
        {
            _cardOpened = false;
        }

        public DebitCard()
        {

        }


    }
    class CreditCard : DebitCard
    {
        private int _negLimit;

        public override void Payment(int amount)
        {
            if (_cardOpened)
            {
                if(_balance + amount + _negLimit > 0)
                {
                    _balance += amount;
                }
                else
                {
                    Console.WriteLine("Payment out of limit!");
                }
            }
        }

        public override void CardInfoPrint()
        {
            base.CardInfoPrint();
            Console.WriteLine("Credit limit: " + _negLimit);
        }

        public CreditCard(string cardType)
        {
            _cardType = cardType;
            _negLimit = 1000;
            _cardOpened = true;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            DebitCard kauri = new DebitCard("Debit");
            kauri.GetBalance();
            kauri.SetBalance(100);
            kauri.GetBalance();
            kauri.Payment(-20);
            kauri.GetBalance();
            kauri.CardInfoPrint();
            Console.ReadLine();

            CreditCard kaurito = new CreditCard("Credit");
            kaurito.GetBalance();
            kaurito.SetBalance(1000);
            kaurito.GetBalance();
            kaurito.Payment(-20);
            kaurito.GetBalance();
            kaurito.CardInfoPrint();
            kaurito.Payment(-2000);
            kaurito.CloseCard();
            kaurito.CardInfoPrint();
            Console.ReadLine();




            /*
            List<Shape> shapesList = new List<Shape>();
            shapesList.Add(new Triangle());
            shapesList.Add(new Square());
            shapesList.Add(new Circle());
            shapesList.Add(new Shape());

            foreach (Shape e in shapesList)
            {
                e.Draw();
                e.Paint("blue");
                e.SetHeight(4);
            }
            Triangle t = new Triangle();
            t.Paint("purple");

            Console.ReadLine(); */

        }
    }


}
