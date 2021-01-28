using System;
using System.Collections.Generic;

namespace RummyConsole.Functions
{
    internal static class Game
    {
        internal static bool Turn = true;
        internal static bool AddedCard;
        internal static bool OrganizeAddedCard;
        internal static bool IsThereListedCards = false;
        internal static List<Card> Selected = new List<Card>();
        internal static Card JokerFound;
        internal static int SelectedList;
        internal static bool Selecting = false;
        internal static bool BackupNeeded = false;
        internal static List<List<Card>> RoundBackup = new List<List<Card>>();

        internal static List<Card> CreateAllCards()
        {
            var newDeck = new List<Card>();
            for (var i = 0; i < 2; i++) { //TwoDeckofCards
                for (var c = 0; c < 14; c++) { //AllTypeofCards
                    if (i == 0 && c == 0) continue;
                    for (var colorIndex = 0; colorIndex < 4; colorIndex++) { //AllColorofCards
                        var newCard = new Card() {
                            Color = (CardColor) colorIndex,
                            Number = c,
                            Joker = c == 0 // 0 is Joker
                        };
                        newDeck.Add(newCard);
                    }
                }
            }
            return newDeck;
        }
        internal static void SetupPlayers(int numOfPlayers, List<Player> players)
        {
            Console.WriteLine("1 - 10 characters\nSet name for:");
            for (var i = 1; i <= numOfPlayers; i++)
            {
                var newPlayer = new Player()
                {
                    PlayerName = WriteNames(i, players)
                };
                players.Add(newPlayer);
            }
        }
        internal static string WriteNames(int numberOfPlayer, List<Player> players)
        {
            var input = string.Empty;
            while (input.Length > 11 || input.Length == 0)
            {
                Console.Write("Player " + numberOfPlayer + " = ");
                input = Console.ReadLine();
                input = SupportFunctions.CheckingExistingNames(input, players);
            }
            return input;
        }
    }
}
