using System;
using System.Collections.Generic;
using System.Linq;

namespace RummyConsole.Functions
{
    internal static class Picking
    {
        internal static void PickACard(Player player, List<Card> unChecked, bool delete)
        {
            var numberOfCardFromDeck = ThreadSafeRandom.ThisThreadsRandom.Next(0, unChecked.Count - 1);
            var pickedCard = unChecked[numberOfCardFromDeck];

            if (delete)
            {
                unChecked.RemoveAt(numberOfCardFromDeck);
                player.Hand.Add(pickedCard);
            }
            else
            {
                player.FirstPick = pickedCard;
            }
        }

        internal static void GiveFirstDeck(List<Player> players, List<Card> unChecked)
        {
            foreach (var player in players)
            {
                for (var i = 0; i < 14; i++) PickACard(player, unChecked, true);
            }
        }
        internal static int FirstPicking(List<Player> realPlayers)
        {
            var highestCards = realPlayers;
            var countHigh = highestCards.Count;
            var moddingPlayers = new List<Player>();

            Console.WriteLine("\nFirst pick!");
            Console.WriteLine("Results:");

            while (countHigh > 1)
            {
                foreach (var player in highestCards.ToList())
                {
                    PickACard(player, Game.CreateAllCards(), false);

                    foreach (var realPlayer in realPlayers)
                    { //save the FirstCard to original player's list.
                        if (player.PlayerName == realPlayer.PlayerName)
                            realPlayer.FirstPick = player.FirstPick;
                    }
                    Console.Write(player.PlayerName + ": "); //print result
                    player.PrintFirstPick();
                    Console.WriteLine();
                    if (moddingPlayers.Count == 0)
                        moddingPlayers.Add(player);
                    else
                    {
                        if (moddingPlayers[0].FirstPick.Number < player.FirstPick.Number)
                        {
                            moddingPlayers = new List<Player> { player };
                        }
                        else if (moddingPlayers[0].FirstPick.Number == player.FirstPick.Number)
                        {
                            moddingPlayers.Add(player);
                        }
                    }
                }
                countHigh = moddingPlayers.Count;
                if (countHigh > 1)
                {
                    Console.WriteLine("\nMore than one higest card. Again!");
                    highestCards = moddingPlayers;
                    moddingPlayers = new List<Player>();
                    Console.ReadLine();
                }
                else
                {
                    var i = 0;
                    foreach (var realPlayer in realPlayers)
                    {
                        if (moddingPlayers[0].PlayerName == realPlayer.PlayerName)
                            return i-1;
                        i++;
                    }
                }
            }
            return 0;
        }
    }
}
