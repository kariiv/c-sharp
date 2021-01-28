using System;
using System.Collections.Generic;

namespace RummyConsole.Functions
{
    internal static class Menu
    {
        internal static int Organize;
        internal static int Place;
        internal static int SortHand;
        internal static int EndTurn;
        internal static void PrintMainMenu(bool playerFirstPlacement, List<Card> hand)
        {
            var count = 1;
            if (playerFirstPlacement)
            {
                Console.Write(count + ") OrganizeTable ");
                Organize = 1;
                count++;
            }
            Console.Write(count + ") CreateNewList ");
            Place = count;
            count++;

            Console.Write(count + ") SortHand ");
            SortHand = count;
            count++;
            if (!Game.AddedCard) {
                Console.WriteLine(count + ") PickUp");
                EndTurn = count;
            }
            else if (hand.Count == 0){
                Console.WriteLine(count + ") RUMMY!");
                EndTurn = count;
            }
            else {
                Console.WriteLine(count + ") End");
                EndTurn = count;
            }
        }
        internal static void MainMenuInputs(List<List<Card>> listedCards, List<Card> unChecked, Player rolling)
        {
            var input = SupportFunctions.StringToInt(Console.ReadLine());

            if (input == Organize && rolling.FirstPlacement)
            {
                Display.MenuStatus = 3;
            }
            if (input == Place)
            {
                Display.MenuStatus = 1;
                Game.Selecting = true;
            }
            else if (input == SortHand)
            {
                Display.MenuStatus = 2;
            }
            else if (input == EndTurn)
            {
                if (!Game.AddedCard)
                {
                    MenuButtons.EndTurn.PickUpFunktion(rolling, unChecked);
                }
                Game.Turn = false;
                Display.MenuStatus = 0;
            }
        }
    }
}
