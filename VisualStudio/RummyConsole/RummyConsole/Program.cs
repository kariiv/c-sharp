using System;
using System.Threading;

namespace RummyConsole
{
    internal class Program
    {
        private static void Main() {
            var run = true;
            while (run) {
                Console.WriteLine("Welcome to Rummy!\n\n1. New Game?\n2. Rules/Info\n3. Quit");
                var input = Console.ReadLine();
                switch (input) {
                    case "1":
                        Game(Setup());
                        break;
                    case "2":
                        Rules();
                        break;
                    case "3":
                        run = Exit();
                        break;
                }
                Console.Clear();
            }
        }
        private static bool Exit() {
            Console.Clear();
            Console.WriteLine("Seriously! Exit The Rummy? (y/n)");
            var inp = Console.ReadLine();
            if (inp == "n")
                return true;
            else {
                Console.WriteLine("Thank you for playing!\nGoodBye!");
                Thread.Sleep(1500);
                return false;
            }
        }
        private static void Rules() {
            Console.Clear();
            Console.WriteLine("1. Lorem Ipsum is simply dummy text of the printing and typesetting industry. " +
                              "\nLorem Ipsum has been the industry's standard dummy text " +
                              "\never since the 1500s, when an unknown printer took a galley \n" +
                              "of type and scrambled it to make a type specimen book. It has \n" +
                              "survived not only five centuries, but also the leap into \n" +
                              "electronic typesetting, remaining essentially unchanged. \n\n" +
                              "2. It was popularised in the 1960s with the release of Letraset \n" +
                              "sheets containing Lorem Ipsum passages, and more recently with \n" +
            "desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n\n" +
                              "Hit \"Return\" to return to Main Menu.");
            Console.ReadLine();
            Console.Clear();
        }
        private static int Setup() {
            var notNumber = true;
            string players = null;
            while (notNumber) {
                Console.Clear();
                Console.WriteLine("New Game! \n");
                Console.Write("2 - 4 players\nHow many players? ");
                players = Console.ReadLine();
                if (players == "2" || players == "3" || players == "4") 
                    notNumber = false;
                else {
                    Console.Clear();
                    Console.WriteLine("Number must be between 2 and 4!");
                }
            }
            Console.WriteLine();
            return short.Parse(players);
        }

        private static void Game(int players) {
            TheGame game = new TheGame(players);
            //TimerCallback callback = new TimerCallback(Tick);
            //Timer timer;
            while (!game.Winner) {
                //timer = new Timer(callback,null, 0, 1000);
                game.TakeTurn();
                Console.ReadLine();
            }
        }
        /*
        static private void Tick(Object stateInfo) {
            Console.WriteLine("Timer Started");
        }*/
        

    }
}
