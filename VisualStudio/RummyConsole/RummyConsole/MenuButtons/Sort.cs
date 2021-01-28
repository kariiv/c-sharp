using System;
using System.Collections.Generic;
using RummyConsole.Functions;

namespace RummyConsole.MenuButtons
{
    internal static class Sort
    {
        internal static void SortingCardFunction(Player rolling)
        {
            Console.WriteLine("Sort by...\n1) Number 2) Color");
            var input = SupportFunctions.StringToInt(Console.ReadLine());
            switch (input)
            {
                case 1:
                    rolling.Hand = ByNumber(rolling.Hand);
                    break;
                case 2:
                    rolling.Hand = ByColor(rolling.Hand);
                    break;
                case 0:
                    Display.MenuStatus = 0;
                    break;
            }
        }
        public static List<Card> ByColor(List<Card> inputList)
        {
            for (var a = 0; a < inputList.Count - 1; a++) 
            for (var b = a; b >= 0; b--) 
                if (inputList[b].Color > inputList[b + 1].Color)
                {
                    var temp = inputList[b];
                    inputList[b] = inputList[b + 1];
                    inputList[b + 1] = temp;
                }
            return inputList;
        }
        public static List<Card> ByNumber(List<Card> inputList)
        {
            for (var a = 0; a < inputList.Count - 1; a++)  
            for (var b = a; b >= 0; b--) 
                if (inputList[b].Number > inputList[b + 1].Number)
                {
                    var temp = inputList[b];
                    inputList[b] = inputList[b + 1];
                    inputList[b + 1] = temp;
                }
            return inputList;
        }
    }
}

