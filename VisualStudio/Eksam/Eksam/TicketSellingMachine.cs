using System;
using System.Collections.Generic;
using System.IO;

namespace Eksam
{
    interface ITicket
    {
        void PrintSoldTickets();
        void SaveAllTicketsToFile();
        void PrintFreeSeats();
        void BaseSettings(double basePrice, int numberOfSeats);
        void SellTicket(string name);
        void SellTicket(string name, string buyingtime);
        void PrintPricesInfo();
    }

    class TicketSellingMachineEconomy : ITicket
    {
        internal Dictionary<string, string> CityCodes = new Dictionary<string, string>();

        //while true - the machine uses city codes in the cityCodes.txt file. Educational use only.
        internal bool ReadFromFile = false; //if false then some values are "unknown"
        internal string CityCodesFile = "cityCodes.txt";
        internal bool DebugDouble = false; //Printing doubled CityCodes

        //List for storing all sold tickets
        internal List<Ticket> SoldTickets = new List<Ticket>();
        internal Ticket Ticket;
        
        internal int NumberOfSeats, Type; //Type: 1 - business, 2 - economy
        private int _numberOfExtraSeats = 0;
        internal double BasePrice;
        internal string Destination, Location, DepartureTime;
        internal DateTime DepartureDateTime;
        internal bool IsDepartureTimeCorrect = true;
        internal int DoubleOccupancyRate;
        internal bool Refundable = false;

        internal string SavePath = "_Tickets.txt";
        public TicketSellingMachineEconomy(string flightCode, string departureTime)
        {
            if (ReadFromFile) //Adding destinations to dictionary
                CityCodesLoadFromFile();
            else
                CityCodesLoadFromList();
            
            LocationsSet(flightCode); //Sets: _destination & _location
            Type = 2; //2 - economy ticket
            DepartureDateTime = DepartureStringToDateTime(departureTime);
            DepartureTime = IsDepartureTimeCorrect ? departureTime : "Incorrect time value.";
            DoubleOccupancyRate = 1;

            SavePath = flightCode + SavePath;
        }

        public TicketSellingMachineEconomy(int numberOfExtraSeats)
        {
            _numberOfExtraSeats = numberOfExtraSeats;
        }
        internal DateTime DepartureStringToDateTime(string departureString)
        {
            try
            {
                return DateTime.Parse(departureString);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid departure time! " + ex.Message);
                IsDepartureTimeCorrect = false;
            }
            return DateTime.MinValue;
        }
        internal void LocationsSet(string flightCode)
        {
            if (flightCode.Substring(8, 1) == "2")
            {
                Destination = CityCodeToName(flightCode.Substring(2, 3));
                Location = CityCodeToName(flightCode.Substring(5, 3));
            }
            else if (flightCode.Substring(8, 1) == "5")
            {
                Destination = CityCodeToName(flightCode.Substring(5, 3));
                Location = CityCodeToName(flightCode.Substring(2, 3));
            }
            else
                Console.WriteLine("Incorrect Flight Code! Please check and create new!");
        }
        internal string CityCodeToName(string cityCode)
        {
            if (CityCodes.TryGetValue(cityCode, out string cityName))
                return cityName;
            return "Unregistered";
        }
        internal void CityCodesLoadFromFile()
        {
            using (StreamReader reader = new StreamReader(CityCodesFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    if (line.Split('\t').Length == 3)
                        try
                        {
                            CityCodes.Add(line.Split('\t')[2], line.Split('\t')[0]);
                        }
                        catch (ArgumentException ex)
                        {
                            if(DebugDouble)
                                Console.WriteLine("ATTENTION! " + ex.Message + " " + line.Split('\t')[2]);
                        }
            }
        }
        internal void CityCodesLoadFromList()
        {
            CityCodes.Add("TLL", "Tallinn");
            CityCodes.Add("TYO", "Tokyo");
            CityCodes.Add("KRS", "Kuressaare");
            CityCodes.Add("BER", "Berlin");
            CityCodes.Add("BLK", "Blackpool");
            CityCodes.Add("KBP", "Kiev");
            //And so on... (There are about 1960 international Code)
        }
        public void BaseSettings(double basePrice, int numberOfSeats)
        {
            BasePrice = basePrice;
            NumberOfSeats = numberOfSeats + _numberOfExtraSeats;
        }
        public void PrintSoldTickets()
        {
            int counter = SoldTickets.Count;
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Ticket " + counter + ":");
                Console.WriteLine(SoldTickets[i].PrintTicketInfo());
                Console.WriteLine();
            }
        }
        public void SaveAllTicketsToFile()
        {
            using (StreamWriter writer = new StreamWriter(SavePath, true))
                foreach (Ticket tick in SoldTickets)
                    writer.WriteLine(tick.PrintTicketInfo());
        }
        public void PrintFreeSeats()
        {
            Console.WriteLine("Free seats: " + FreeSeats() + "/" + NumberOfSeats + "\n");
        }
        internal int FreeSeats()
        {
            return NumberOfSeats - SoldTickets.Count;
        }
        public virtual void SellTicket(string name)
        {
            SellingTicket(name, DateTime.Now);
        }
        public virtual void SellTicket(string name, string buyingtime)
        {
            try
            {
                SellingTicket(name, DateTime.Parse(buyingtime));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Inserted date is incorrect! Selling ticket ignored...\n" + ex);
            }
        }
        internal void SellingTicket(string name, DateTime buyTime)
        {
            if (FreeSeats() > 0)
                if (DateTime.Now < DepartureDateTime)
                {
                    SoldTickets.Add(CreateTicket(name, Pricing(buyTime)));
                    Console.WriteLine(Ticket.PrintTicketInfo() + "\n");
                }
                else
                    Console.WriteLine("Invalid flight date.");
            else
                Console.WriteLine("Sorry, all tickets are sold out.\n");
        }
        internal virtual double Pricing(DateTime time)
        {
            Refundable = false;
            return ApplyOccupancyRate(ApplyTimeRate(ApplyWeekdayRate(BasePrice), time));
        }
        internal Ticket CreateTicket(string name, double price)
        {
            Ticket = new Ticket
            {
                Name = name,
                FlightDate = DepartureTime,
                Price = price,
                Destination = Destination,
                Location = Location,
                Type = Type,
                Refundable = Refundable,
                Seat = SoldTickets.Count + 1
            };
            return Ticket;
        }
        internal double ApplyWeekdayRate(double price)
        {
            if (DepartureDateTime.DayOfWeek == DayOfWeek.Friday || DepartureDateTime.DayOfWeek == DayOfWeek.Saturday)
                return price * 1.15;
            return price;
        }
        internal double ApplyTimeRate(double price, DateTime time)
        {
            if (DepartureDateTime != DateTime.MinValue)
            {
                TimeSpan span = DepartureDateTime - time;
                DateTime datespan = DateTime.MinValue + span;
                if (datespan.Month - 1 < 6)
                    return price * (6 - (datespan.Month - 1)) * 0.1 + price;
                return price;
            }
            else
                return 0;
        }
        internal double ApplyOccupancyRate(double price)
        {
            double occupancyRate = Convert.ToDouble(SoldTickets.Count) / Convert.ToDouble(NumberOfSeats) * 100;
            if(occupancyRate > 75)
                return Math.Round(price * 0.17 * DoubleOccupancyRate + price, 2);
            else if (occupancyRate > 50)
                return Math.Round(price * 0.13 * DoubleOccupancyRate + price, 2);
            else if (occupancyRate > 25)
                return Math.Round(price * 0.1 * DoubleOccupancyRate + price, 2);
            return price;
        }
        public void PrintPricesInfo()
        {
            if (SoldTickets.Count > 2)
            {
                double high1, low1, avarage = 0;
                List<double> prices = new List<double>();
                foreach (Ticket tick in SoldTickets)
                {
                    prices.Add(tick.Price);
                    avarage += tick.Price;
                }
                prices.Sort();
                low1 = prices[0];
                high1 = prices[prices.Count - 1];
                if (SoldTickets.Count >= 5)
                {
                    double low2 = prices[1];
                    double high2 = prices[prices.Count - 2];
                    avarage = Math.Round(avarage / prices.Count, 2);
                    Console.WriteLine("There are {0} tickets sold:\n1. High price: {2}\n2. High price: {4}\n2. Low price: {3}\n1. Low price: {1}\nAvarage price: {5}\n", SoldTickets.Count, low1, high1, low2, high2, avarage);
                }
                else
                    Console.WriteLine("There are {0} tickets sold:\nThe higest price: {2}\nThe lowest price: {1}\n", SoldTickets.Count, low1, high1);
            }
            else
                Console.WriteLine("Cannot print info about the prices! Too few tickets!\n");
        }
    }
    class TicketSellingMachineBusiness : TicketSellingMachineEconomy
    {
        private bool _isBusnessAvailable;
        public TicketSellingMachineBusiness(string flightCode, string departureTime) : base(flightCode, departureTime)
        {
            _isBusnessAvailable = IsBusinessAvailable(flightCode);
            if (!_isBusnessAvailable)
            {
                Destination = null;
                Location = null;
                DepartureTime = null;
                DepartureDateTime = DateTime.MinValue;
            }
            else
            {
                DoubleOccupancyRate = 2;
                Type = 1; //1 - business ticket
            }
        }

        private bool IsBusinessAvailable(string flightCode)
        {
            if (flightCode.EndsWith("b"))
                return true;
            Console.WriteLine("Business class is not available.");
            return false;
        }
        internal override double Pricing(DateTime time)
        {
            return RefundableTicket(ApplyOccupancyRate(ApplyTimeRate(BasePrice, time)));
        }
        private double RefundableTicket(double price)
        {
            Console.Write("Your business class ticket price is {0}. Would you like to buy a refundable ticket instead?\nIt would cost {1} euro. y/n - ", price, (price*1.2));
            string input = Console.ReadLine()?.ToLower();
            while (input != "n")
            {
                if (input == "y")
                {
                    Refundable = true;
                    return price * 1.2;
                }
                input = Console.ReadLine()?.ToLower();
            }
            Refundable = false;
            return price;
        }
        public override void SellTicket(string name)
        {
            if (_isBusnessAvailable)
                base.SellTicket(name);
            else
                Console.WriteLine("Business class is not available.");
        }
        public override void SellTicket(string name, string buyingtime)
        {
            if (_isBusnessAvailable)
                base.SellTicket(name, buyingtime);
            else
                Console.WriteLine("Business class is not available.");
        }
    }
}