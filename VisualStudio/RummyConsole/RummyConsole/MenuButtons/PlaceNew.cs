using System;
using System.Collections.Generic;
using RummyConsole.Functions;

namespace RummyConsole.MenuButtons
{
    internal static class PlaceNew
    {
        internal static void AddNewListToTable(List<List<Card>> listedCards,Player rolling)
        {
            Console.Write("Select: ");

            var input = SupportFunctions.StringToInt(Console.ReadLine());
            if (input <= rolling.Hand.Count && input != 0)
            {
                if (rolling.Hand[input - 1].Joker && !rolling.Hand[input - 1].SetJoker())
                    return;
                Game.Selected.Add(rolling.Hand[input - 1]);
                rolling.Hand.RemoveAt(input - 1);
            }
            else if (input == 0) // Kui esimene kord pole käidud siis kõik mis on kinnitatud nimekirjas aga punkte koos ei ole, kustutatakse.
            {
                if (Game.Selected.Count > 0) {
                    Game.Selected = Sort.ByNumber(Game.Selected);
                    if (Rules.ListRules(Game.Selected)) {
                        if (!rolling.FirstPlacement) //Kui esimene käik
                        {
                            Game.RoundBackup.Add(Game.Selected);
                            Rules.PlacementRules(rolling);
                            if (rolling.FirstPlacement)
                            {
                                foreach (var list in Game.RoundBackup)
                                {
                                    listedCards.Add(list);
                                }
                                Game.RoundBackup = new List<List<Card>>();
                            }
                        }
                        else
                        {
                            listedCards.Add(Game.Selected);
                            Rules.PlacementRules(rolling);
                        }
                    }
                    else
                    {
                        SupportFunctions.ListToList(rolling.Hand, Game.Selected, true);
                    }
                    Game.Selected = new List<Card>();
                }
                else if (!rolling.FirstPlacement && Game.RoundBackup.Count > 0) {
                    foreach (var list in Game.RoundBackup)
                    {
                        SupportFunctions.ListToList(rolling.Hand, list, true);
                    }
                    Game.RoundBackup = new List<List<Card>>();
                }
                else
                {
                    Display.MenuStatus = 0;
                    Game.Selecting = false;
                }
            }
        }
    }
}
