using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PractiseForTest
{
    interface ITickets
    {
        void SellTicket(int distance); //value must be in rage 0-80
        void TicketInfo(); //Prints Info
    }
    class Silver : ITickets //No Discoount
    {
        internal int _price;
        internal string _zone;
        internal List<int> price = new List<int>();
        internal string _nameMachine;

        public Silver(string name)
        {
            _nameMachine = name;
            price.Add(3);
            price.Add(4);
            price.Add(5);
        }
        

        public virtual void SellTicket(int distance)
        {
            if (distance < 31)
            {
                _zone = "Zone A";
                _price = price[0];
            }
            else if (distance < 61)
            {
                _zone = "Zone A";
                _price = price[1];
            }

            else if (distance < 81)
            {
                _zone = "Zone A";
                _price = price[2];
            }
            else
                Console.WriteLine("Distance range must be 0-80");
            
            if (distance < 81)
                TicketInfo();
        }
        public void TicketInfo()
        {
            Console.WriteLine("You bought a ticket from {0}, for {1} and with price {2}", _nameMachine, _zone, _price);
        }
    }

    class Bronze : Silver //Discount 10%(every fifth),
    {
        internal int _discountion;
        internal int _discount;
        public Bronze(string name):base(name)
        {
            _discount = 10;
            _discountion = 0;
            
        }

        public override void SellTicket(int distance)
        {
            base.SellTicket(distance);
            if (distance < 81)
                _discountion += 1;
        }


    }
    class Gold : Bronze // Discount 20%(every fourth),
    {
        public Gold(string name):base(name)
        {
            price[0] = 5;
            price[1] = 7;
            price[2] = 9;
            _discount = 10;
            _discountion = 0;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Bronze BroTic = new Bronze("Supromo500"); 
            Silver SilTic = new Silver("Makstro1000");
            Gold GoTic = new Gold("Megraan5K");
            bool RUN = true;
            bool run = true;

            while (RUN)
            {
                int distance = 0;
                while (run)
                {
                    Console.WriteLine("Insert distance!");
                    try
                    {
                        distance = int.Parse(Console.ReadLine());
                        run = false;
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Non-Numbering char included, please try again");
                    }
                }
                Console.Clear();
                while (!run)
                {
                    Console.WriteLine("Ticket type:\n1) Bronze ticket\n2) Silver ticket\n3) Golden ticket");
                    string InP = Console.ReadLine();
                    Console.Clear();
                    if (InP == "1")
                    {
                        BroTic.SellTicket(distance);
                        Console.WriteLine("Click any key to continue...");
                        Console.ReadLine();
                        run = true;
                    }
                    else if (InP == "2")
                    {
                        SilTic.SellTicket(distance);
                        Console.WriteLine("Click any key to continue...");
                        Console.ReadLine();
                        run = true;
                    }
                    else if (InP == "3")
                    {
                        GoTic.SellTicket(distance);
                        Console.WriteLine("Click any key to continue...");
                        Console.ReadLine();
                        run = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection!");
                    }
                    Console.Clear();
                }
            }
            




            Console.WriteLine("GoodBye!");
            Thread.Sleep(2000);

        }
    }
}
