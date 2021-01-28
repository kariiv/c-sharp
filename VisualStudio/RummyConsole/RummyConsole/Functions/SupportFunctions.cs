using System;
using System.Collections.Generic;
using System.Linq;

namespace RummyConsole.Functions
{
    internal static class SupportFunctions
    {
        internal static int StringToInt(string input)
        {
            if (input == null) return 0;
            if (input.All(Char.IsDigit) && input != string.Empty)
            {
                return Int16.Parse(input);
            }
            return 0;
        }
        public static void ListToList(List<Card> to, List<Card> from, bool deJoker)
        {
            foreach (var card in from) {
                to.Add((card.Joker && deJoker) ? new Card {Joker = true} : card);
            }
        }
        internal static string CheckingExistingNames(string name, List<Player> players)
        {
            foreach (var player in players)
            {
                if (player.PlayerName == name)
                    return string.Empty;
            }
            return name;
        }
        internal static bool JokerFound(List<Card> list) {
            foreach (var card in list) {
                if (!card.Joker) continue;
                Game.JokerFound = card;
                return true;
            }
            return false;
        }
    }
}