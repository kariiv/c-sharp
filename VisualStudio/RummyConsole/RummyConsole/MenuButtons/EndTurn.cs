using System;
using System.Collections.Generic;
using RummyConsole.Functions;

namespace RummyConsole.MenuButtons
{
    internal static class EndTurn
    {
        internal static void PickUpFunktion(Player rolling, List<Card> unChecked)
        {
            if (unChecked.Count == 0)
            {
                Console.Write("No more cards left.");
            }
            else
            {
                Picking.PickACard(rolling, unChecked, true);
                Console.Write("New card: ");
                rolling.Hand[rolling.Hand.Count - 1].PrintCard();
            }
            Console.ReadLine();
        }
    }
}
