using System.Collections.Generic;

namespace RummyConsole
{
    internal class Player
    {
        public Card FirstPick { get; set; }
        public List<Card> Hand = new List<Card>();
        public bool FirstPlacement = false;
        public string PlayerName { get; set; }

        public void PrintFirstPick() {
            FirstPick.PrintCard();
        }
    }
}
