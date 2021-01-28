using System.Collections.Generic;
using NUnit.Framework;
using RummyConsole.Functions;

namespace RummyConsole
{
    [TestFixture]
    internal class RulesTests
    {
        private Card _redCard1;
        private Card _redCard2;
        private Card _redCard3;
        private Card _redCard4;
        private Card _redCard5;
        private Card _redCard11;
        private Card _redCard12;
        private Card _redCard13;
        private Card _jokerCard1;
        private Card _jokerCard2;
        private Card _jokerCard3;
        private Card _blueCard3;
        private Card _greenCard3;
        private Card _yellowCard3;

        private List<Card> _cards;

        [SetUp]
        public void TestSetup()
        {
            _redCard1 = new Card { Color = CardColor.Red, Number = 1 };
            _redCard2 = new Card { Color = CardColor.Red, Number = 2 };
            _redCard3 = new Card { Color = CardColor.Red, Number = 3 };
            _redCard4 = new Card { Color = CardColor.Red, Number = 4 };
            _redCard5 = new Card { Color = CardColor.Red, Number = 5 };
            _redCard11 = new Card { Color = CardColor.Red, Number = 11 };
            _redCard12 = new Card { Color = CardColor.Red, Number = 12 };
            _redCard13 = new Card { Color = CardColor.Red, Number = 13 };
            _blueCard3 = new Card { Color = CardColor.Blue, Number = 3 };
            _greenCard3 = new Card { Color = CardColor.Green, Number = 3 };
            _yellowCard3 = new Card { Color = CardColor.Yellow, Number = 3 };

            _cards = new List<Card>();
        }
        [Test]
        public void Rules_PlacementVer1()
        {
            _cards.Add(_redCard2);
            _cards.Add(_redCard3);
            _cards.Add(_redCard4);
            Assert.That(Rules.ListRules(_cards));
        }
        [Test]
        public void Rules_PlacementVer2_jokers()
        {
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Red, Number = 2 };
            _cards.Add(_jokerCard2);
            _cards.Add(_redCard3);
            _cards.Add(_redCard4);

            Assert.That(Rules.ListRules(_cards));
        }
        [Test]
        public void Rules_PlacementVer3_jokers()
        {
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Yellow, Number = 3 };
            _cards.Add(_jokerCard2);
            _cards.Add(_redCard3);
            _cards.Add(_blueCard3);
            Assert.That(Rules.ListRules(_cards));
        }
        [Test]
        public void Rules_PlacementVer4_OnlyJokers()
        {
            _jokerCard1 = new Card { Joker = true, Color = CardColor.Yellow, Number = 2 };
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Green, Number = 2 };
            _jokerCard3 = new Card { Joker = true, Color = CardColor.Blue,  Number = 2 };
            _cards.Add(_jokerCard2);
            _cards.Add(_jokerCard1);
            _cards.Add(_jokerCard3);
            Assert.That(Rules.ListRules(_cards));
        }
        [Test]
        public void Rules_PlacementVer5_OnlyJokers()
        {
            _jokerCard1 = new Card { Joker = true, Color = CardColor.Yellow, Number = 0 };
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Green, Number = 0 };
            _jokerCard3 = new Card { Joker = true, Color = CardColor.Blue, Number = 0 };
            _cards.Add(_jokerCard2);
            _cards.Add(_jokerCard1);
            _cards.Add(_jokerCard3);
            Assert.That(!Rules.ListRules(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestCorrectVer1()
        {
            _cards.Add(_redCard1);
            _cards.Add(_redCard2);
            _cards.Add(_redCard3);
            _cards.Add(_redCard4);
            _cards.Add(_redCard5);
            Assert.That(Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestCorrectVer2()
        {
            _cards.Add(_redCard11);
            _cards.Add(_redCard12);
            _cards.Add(_redCard13);
            Assert.That(Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestCorrectVer2Joker()
        {
            _jokerCard1 = new Card { Joker = true, Color = CardColor.Red, Number = 2 };
            _cards.Add(_jokerCard1);
            _cards.Add(_redCard3);
            _cards.Add(_redCard4);
            Assert.That(Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestCorrectVer3Joker(){
            _jokerCard1 = new Card { Joker = true, Color = CardColor.Red, Number = 2 };
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Red, Number = 4 };
            _cards.Add(_jokerCard1);
            _cards.Add(_redCard3);
            _cards.Add(_jokerCard2);
            Assert.That(Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestCorrectVer4Joker()
        {
            _jokerCard1 = new Card { Joker = true, Color = CardColor.Red, Number = 3 };
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Red, Number = 4 };
            _cards.Add(_redCard2);
            _cards.Add(_jokerCard1);
            _cards.Add(_jokerCard2);
            Assert.That(Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestCorrectVer5Joker()
        {
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Red, Number = 4 };
            _cards.Add(_redCard2);
            _cards.Add(_redCard3);
            _cards.Add(_jokerCard2);
            Assert.That(Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestInCorrect()
        {
            _cards.Add(_redCard1);
            _cards.Add(_redCard3);
            _cards.Add(_redCard4);
            _cards.Add(_redCard5);
            Assert.That(!Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestInCorrectEndJoker()
        {
            _cards.Add(_redCard12);
            _cards.Add(_redCard13);
            _cards.Add(_jokerCard2);
            Assert.That(!Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestInCorrectEndInvertedJoker()
        {
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Red, Number = 14 };
            _cards.Add(_jokerCard2);
            _cards.Add(_redCard13);
            _cards.Add(_redCard12);
            Assert.That(!Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestInCorrectStartJoker()
        {
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Red, Number = 0 };
            _cards.Add(_jokerCard2);
            _cards.Add(_redCard1);
            _cards.Add(_redCard2);
            _cards.Add(_redCard3);
            Assert.That(!Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_StraightFlushTestInCorrectStartInvertedJoker()
        {
            _cards.Add(_redCard3);
            _cards.Add(_redCard2);
            _cards.Add(_redCard1);
            _cards.Add(_jokerCard2);
            Assert.That(!Rules.StraightFlush(_cards));
        }
        [Test]
        public void Rules_HouseTestCorrectVer1()
        {
            _cards.Add(_redCard3);
            _cards.Add(_yellowCard3);
            _cards.Add(_greenCard3);
            Assert.That(Rules.House(_cards));
        }
        [Test]
        public void Rules_HouseTestCorrectVer2Joker()
        {
            _jokerCard1 = new Card { Joker = true, Color = CardColor.Yellow, Number = 2 };
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Blue, Number = 2 };
            _cards.Add(_jokerCard1);
            _cards.Add(_redCard2);
            _cards.Add(_jokerCard2);
            Assert.That(Rules.House(_cards));
        }
        [Test]
        public void Rules_HouseTestCorrectVer3Joker()
        {
            _jokerCard1 = new Card{ Joker = true, Color = CardColor.Green, Number = 2};
            _jokerCard2 = new Card { Joker = true, Color = CardColor.Blue, Number = 2 };
            _cards.Add(_redCard2);
            _cards.Add(_jokerCard1);
            _cards.Add(_jokerCard2);
            Assert.That(Rules.House(_cards));
        }
    }
}
