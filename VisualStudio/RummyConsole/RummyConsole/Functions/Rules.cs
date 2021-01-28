using System.Collections.Generic;
using System.Linq;

namespace RummyConsole.Functions
{
    internal static class Rules
    {
        internal static bool CheckAllListedCards(List<List<Card>> listedCards) {
            foreach (var list in listedCards) {
                if (!ListRules(list))
                    return false;
            }
            return true;
        }
        internal static void PlacementRules(Player rolling) {
            Game.AddedCard = true;

            if (!rolling.FirstPlacement)
                if(SumUpCards(Game.RoundBackup) >= 30)
                    rolling.FirstPlacement = true;
            if (!Game.IsThereListedCards)
                Game.IsThereListedCards = true;
        }
        internal static bool ListRules(List<Card> list) {
            if (list.Count < 3)
                return false;
            return (House(list) || StraightFlush(list));
        }
        internal static int SumUpScore(List<Card> newCardList) {
            var sum = 0;
            foreach (var card in newCardList) {
                if(!card.Joker)
                    sum += card.Number;
                else
                    sum += 25;
            }
            return sum;
        }
        internal static int SumUpCards(List<List<Card>> listList)
        {
            return (from list in listList select SumUpCardsInList(list)).Sum();
        }
        internal static int SumUpCardsInList(List<Card> listCards)
        {
            return (from card in listCards select card.Number).Sum();
        }

        internal static bool StraightFlush(List<Card> list) {//Rida
            var listColor = list[0].Color;
            
            foreach (var card in list) //All Must Be The Same Color
            {
                if (card.Color != listColor)
                    return false;
            }

            var direction = list[1].Number - list[0].Number;
            if (direction > 1 || direction < -1 || direction == 0)
                return false;

            var cardIndex = -1;
            foreach (var card in list)
            {
                if (cardIndex != -1) {
                    if (card.Number != cardIndex) //Checking Card Valitation
                        return false;
                }
                else //Sets First Card Number
                {
                    cardIndex = card.Number;
                }
                if (cardIndex < 1 || cardIndex > 13) //DUBLIKAAT
                    return false;
                cardIndex += direction;
            }
            return true;
        }

        internal static bool House(List<Card> list) {//Väärtus
            if (list.Count > 4)
                return false;

            var listNumber = list[0].Number;

            if (listNumber < 1 || listNumber > 13) //DUBLIKAAT
                return false;
            
            foreach (var card in list)
            {
                if (card.Number != listNumber)
                    return false;
            }

            var red = false;
            var green = false;
            var blue = false;
            var yellow = false;

            foreach (var card in list) {
                switch (card.Color) {
                    case CardColor.Red when !red:
                        red = true;
                        break;
                    case CardColor.Green when !green:
                        green = true;
                        break;
                    case CardColor.Blue when !blue:
                        blue = true;
                        break;
                    case CardColor.Yellow when !yellow:
                        yellow = true;
                        break;
                    default:
                        return false;
                }
            }
            return true;
        }
    }
}
