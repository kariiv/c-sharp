using System;
using System.Collections.Generic;
using System.Linq;
using RummyConsole.Functions;

namespace RummyConsole.MenuButtons
{
    internal static class Organize //Add joker to new list and 
    {
        internal static void OrganizeListSelection(List<List<Card>> listedCards, Player rolling)
        {
            Console.WriteLine("Select a list...");
            var input = SupportFunctions.StringToInt(Console.ReadLine());

            if (input > 0 && input <= listedCards.Count)
            {
                Game.SelectedList = input - 1;
                if (listedCards[Game.SelectedList].Count == 1) {
                    if (listedCards[Game.SelectedList][0].Joker && !listedCards[Game.SelectedList][0].SetJoker())
                        return;
                }
                Game.Selecting = true;
                Display.MenuStatus = 5;
            }
            else if (input == 0)
            {
                if (!Rules.CheckAllListedCards(listedCards)) {
                    Game.BackupNeeded = true;
                    Game.OrganizeAddedCard = false;
                }
                else
                    Game.RoundBackup = new List<List<Card>>();

                if (Game.OrganizeAddedCard)
                    Game.AddedCard = true;

                Game.SelectedList = 0;
                Game.Selecting = false;
                Display.MenuStatus = 0;
            }
        }
        internal static void OrganizingTaskMenu()
        {
            Console.WriteLine("1) AddCard(s) 2) AddList 3) Split");
            var input = SupportFunctions.StringToInt(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Display.MenuStatus = 6; //CardToList
                    break;
                case 2:
                    Display.MenuStatus = 7; //ListToList 
                    break;
                case 3:
                    Display.MenuStatus = 8; //split
                    break;
                case 4:
                    Display.MenuStatus = 4; //flipList
                    break;
                case 0:
                    Display.MenuStatus = 3; //back
                    break;
            }
        }
        internal static void AddCardToList(List<List<Card>> listedCards, Player rolling)
        {
            Console.WriteLine("Select card...");
            var input = SupportFunctions.StringToInt(Console.ReadLine())-1;
            if (input < rolling.Hand.Count && input >= 0) {
                if (SupportFunctions.JokerFound(listedCards[Game.SelectedList])) {
                    if (Game.JokerFound.Color == rolling.Hand[input].Color &&
                        Game.JokerFound.Number == rolling.Hand[input].Number) {
                        listedCards[Game.SelectedList].Remove(Game.JokerFound);
                        listedCards.Add(new List<Card>{new Card{Joker = true}});
                    }
                }
                else if (rolling.Hand[input].Joker && !rolling.Hand[input].SetJoker())
                    return;
                listedCards[Game.SelectedList].Add(rolling.Hand[input]);
                listedCards[Game.SelectedList] = Sort.ByNumber(listedCards[Game.SelectedList]);

                rolling.Hand.RemoveAt(input);
                Game.OrganizeAddedCard = true;
            }
            else if (input == -1)
                Display.MenuStatus = 5;
        }
        internal static void AddListToList(List<List<Card>> listedCards)
        {
            Console.WriteLine("Select list to add...");
            var input = SupportFunctions.StringToInt(Console.ReadLine()) - 1;
            if (input != Game.SelectedList && input < listedCards.Count && input >= 0) //SIIN
            {
                if (listedCards[input].Count == 1)
                {
                    if (listedCards[input][0].Joker && !listedCards[input][0].SetJoker())
                        return;
                }
                SupportFunctions.ListToList(listedCards[Game.SelectedList], listedCards[input], false);
                listedCards.RemoveAt(input);
                if (Game.SelectedList > input)
                    Game.SelectedList -= 1;
                listedCards[Game.SelectedList] = Sort.ByNumber(listedCards[Game.SelectedList]);
            }
            Display.MenuStatus = 5;
        }
        internal static void SplitSelectedList(List<List<Card>> listedCards)
        {
            Console.WriteLine("At...");
            var input = SupportFunctions.StringToInt(Console.ReadLine())-1;
            if (input > 0 && input < listedCards[Game.SelectedList].Count)
            {
                listedCards.Insert(Game.SelectedList+1, listedCards[Game.SelectedList].Skip(input).ToList());
                listedCards[Game.SelectedList] = listedCards[Game.SelectedList].Take(input).ToList();
            }
            Display.MenuStatus = 5;
        }
    }
}
