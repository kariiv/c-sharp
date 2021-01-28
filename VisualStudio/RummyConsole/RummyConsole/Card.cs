using System;

namespace RummyConsole
{
    public enum CardColor
    {
        Red,
        Green,
        Blue,
        Yellow,
        Gray
    };
    [Serializable]
    internal class Card
    {
        private bool _joker;
        public bool Joker {
            get => _joker;
            set {
                if (value) {
                    _joker = true;
                    Number = 0;
                    Color = CardColor.Gray;
                }
                else {
                    _joker = false;
                }
            }
        }
        public int Number; //0-13 / 0 = Joker
        public CardColor Color;

        public void PrintCard()
        {
            switch ((int) Color) {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
            if (Joker)
                Console.Write("J");
            else
                Console.Write(Number);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public bool SetJoker() {
            Console.Write("Joker is ");
            var inp = Console.ReadLine();
            if (string.IsNullOrEmpty(inp)) return false;
            if (inp.Length >= 4 || inp.Length <= 1) return false;
            var colorStr = inp.Substring(0,1).ToLower();
            if (!short.TryParse(inp.Substring(1,inp.Length-1), out var number))
                if(number > 13 || number < 1) return false;
            switch (colorStr)
            {
                case "r":
                    Color = CardColor.Red;
                    break;
                case "g":
                    Color = CardColor.Green;
                    break;
                case "b":
                    Color = CardColor.Blue;
                    break;
                case "y":
                    Color = CardColor.Yellow;
                    break;
                default:
                    return false;
            }
            Number = number;
            return true;
        }
    }
}
