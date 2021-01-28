using System;

namespace Eksam
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();

            string[] names = new string[10];
            names[0] = "Kauri Riivik";
            names[1] = "Mari Maasikas";
            names[2] = "Kristen Ratasep";
            names[3] = "Carl Reidolf";
            names[4] = "Virge Pent";
            names[5] = "Anna Vainomae";
            names[6] = "Valdur Vainomae";
            names[7] = "Jana Sarnavskaja";
            names[8] = "Karmen Sillamaa";
            names[9] = "Rainer Rajaste";

            TicketSellingMachineEconomy economy1 = new TicketSellingMachineEconomy("EATLLTYO2b", "2019.01.13");
            economy1.BaseSettings(145, 80);

            for(int count = 0; count < 80; count++) //Filling plane with people
            {
                int randomName = rnd.Next(0, 9);
                economy1.SellTicket(names[randomName]);
            }
            economy1.SellTicket(names[0]); //Plane Full Error
            economy1.PrintPricesInfo();
            
            TicketSellingMachineEconomy economy2 = new TicketSellingMachineEconomy("EABERCSI5", "2019.02.15");
            economy2.BaseSettings(330, 5);
            economy2.SellTicket(names[4]);
            economy2.SellTicket(names[3]);
            economy2.PrintPricesInfo(); //Too few tickets
            economy2.SellTicket(names[2]);
            economy2.PrintFreeSeats();
            economy2.PrintSoldTickets();
            economy2.PrintPricesInfo();
            
            TicketSellingMachineBusiness business1 = new TicketSellingMachineBusiness("EAKBPBLK5", "2019.02.15"); //TestError: Business class not available
            business1.SellTicket(names[0]); // Business not available
            Console.WriteLine();

            TicketSellingMachineBusiness business2 = new TicketSellingMachineBusiness("EABERKRS2b", "2019.02.15");
            business2.BaseSettings(175, 60);

            for (int count = 0; count < 61; count++) //Filling plane with people
            {
                int randomName = rnd.Next(0, 9);
                business2.SellTicket(names[randomName]);
                business2.PrintFreeSeats();
            }
            business2.SaveAllTicketsToFile();
    
            Console.ReadLine();
        }
    }
}
