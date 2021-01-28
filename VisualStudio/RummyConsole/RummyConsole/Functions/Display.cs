using System;
using System.Collections.Generic;

namespace RummyConsole.Functions
{
    internal static class Display
    {
        internal static int MenuStatus = 0;
        internal static void RoundPlayerHeadding(Player rolling)
        {
            Console.WriteLine("It's " + rolling.PlayerName + "'s turn!\n");
        }

        public static void PrintListedCards(List<List<Card>> listedCards)
        {
            if (listedCards.Count == 0)
            {
                Console.WriteLine("No cards on field");
                return;
            }
            Console.WriteLine("Table...");
            var count = 0;
            foreach (var list in listedCards)
            {
                if (Game.Selecting && MenuStatus != 1) {
                    if (count == Game.SelectedList)
                        Console.Write("-> ");
                    else
                    {
                        Console.Write("   ");
                    }
                }
                count++;
                foreach (var card in list)
                {
                    card.PrintCard();
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
        }

        internal static void PrintBackUpList() {

            foreach (var list in Game.RoundBackup)
            {
                foreach (var card in list)
                {
                    card.PrintCard();
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintPlayerCards(Player rolling)
        {
            Console.WriteLine("\nHand...");
            string border = null;
            foreach (var card in rolling.Hand)
            {
                card.PrintCard();
                Console.Write(" ");
                border += card.Number + " ";
            }
            Console.WriteLine();
            if(rolling.Hand.Count != 0)
                Ruler(border);
        }

        public static void PrintNewList(List<Card> thisList)
        {
            Console.WriteLine("\nSelecting...");
            foreach (var card in thisList)
            {
                card.PrintCard();
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        internal static void Ruler(string numbers)
        {
            var wasSpace = true;
            var skip = false;
            var counter = 1;
            foreach (var character in numbers)
            {
                if (character == ' ')
                { //space
                    if (skip)
                        skip = false;
                    else
                        Console.Write("-");
                    wasSpace = true;
                }
                else if (counter % 5 == 0 && wasSpace) //numbers every 5
                {
                    Console.Write(counter);
                    if (counter > 9)
                        skip = true;
                    wasSpace = false;
                    counter++;
                }
                else if (character != ' ' && wasSpace)
                { //number hit
                    Console.Write("-");
                    wasSpace = false;
                    counter++;
                }
                else //double number
                    Console.Write("-");
            }
            Console.WriteLine("\b ");
        }

        internal static void WeHaveWinner(string playerName) {
            Console.Clear();
            Console.WriteLine("\nWE HAVE A WINNER!!!\nCongrats " + playerName + "!");
        }
        internal static int NextPlayer(int playerIndex, List<Player> players)
        {
            playerIndex = playerIndex + 1;
            if (playerIndex >= players.Count)
                playerIndex = 0;
            Console.WriteLine("Next is " + players[playerIndex].PlayerName);
            Console.WriteLine("\nHands...");
            foreach (var player in players) {
                if(player == players[playerIndex]) continue;
                Console.Write(player.PlayerName + " ");
                for (var i = 0; i < player.Hand.Count; i++) {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            return playerIndex;
        }
    }
}
