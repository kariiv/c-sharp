using System;
using System.Collections.Generic;
using RummyConsole.Functions;
using RummyConsole.MenuButtons;

namespace RummyConsole
{
    internal class TheGame
    {
        public bool Winner;
        private readonly List<Player> _players;
        private readonly List<Card> _unChecked;
        private List<List<Card>> _listedCards;
        private int _whoIsPlaying;
        private bool _firstTurn = true;
        private Player _playingPlayer;

        public TheGame(int numOfPlayers) {
            Winner = false;
            _players = new List<Player>();
            Game.SetupPlayers(numOfPlayers,  _players);
            _unChecked = Game.CreateAllCards();
            _unChecked.Shuffle();
            _listedCards = new List<List<Card>>();
        }

        public TheGame() {

        }
            //MAIN LOOP
        public void TakeTurn() {
            _playingPlayer = _players[_whoIsPlaying];
            if (!_firstTurn) {
                while (Game.Turn) {
                    Console.Clear();
                    DisplayOption();
                    PrintButtons();
                }
                if (_playingPlayer.Hand.Count == 0)
                {
                    Display.WeHaveWinner(_playingPlayer.PlayerName);
                    Winner = true;
                    return;
                }
            }
            else {
                _whoIsPlaying = Picking.FirstPicking(_players);
                _firstTurn = false;
                Picking.GiveFirstDeck(_players, _unChecked);
                Console.ReadLine();
            }
            Console.Clear();
            _whoIsPlaying = Display.NextPlayer(_whoIsPlaying, _players);
            Game.Turn = true;
            Game.AddedCard = false;
        }
            //MAIN LOOP
        private void DisplayOption() {
            Display.RoundPlayerHeadding(_playingPlayer);
            Display.PrintListedCards(_listedCards);
            if(Display.MenuStatus == 1)
                Display.PrintNewList(Game.Selected);
            if (!_playingPlayer.FirstPlacement && Display.MenuStatus == 1)
                Display.PrintBackUpList();
            Display.PrintPlayerCards(_playingPlayer);
        }

        internal void PrintButtons() {
            switch (Display.MenuStatus) {
                case 0:
                    Menu.PrintMainMenu(_playingPlayer.FirstPlacement, _playingPlayer.Hand);
                    Menu.MainMenuInputs(_listedCards, _unChecked, _playingPlayer);
                    if (Display.MenuStatus == 3) {
                        Game.RoundBackup = new List<List<Card>>(_listedCards.Clone());
                        Game.RoundBackup.Insert(0, _playingPlayer.Hand.Clone());
                    }
                    break;
                case 1:
                    PlaceNew.AddNewListToTable(_listedCards, _playingPlayer);
                    break;
                case 2:
                    Sort.SortingCardFunction(_playingPlayer);
                    break;
                case 3:
                    Organize.OrganizeListSelection(_listedCards, _playingPlayer);
                    if (Game.BackupNeeded) {
                        _playingPlayer.Hand = Game.RoundBackup[0].Clone();
                        Game.RoundBackup.RemoveAt(0);
                        _listedCards = Game.RoundBackup.Clone();
                        Game.RoundBackup = new List<List<Card>>();
                        Game.BackupNeeded = false;
                    }
                    break;
                case 5:
                    Organize.OrganizingTaskMenu();
                    break;
                case 6:
                    Organize.AddCardToList(_listedCards, _playingPlayer);
                    break;
                case 7:
                    Organize.AddListToList(_listedCards);
                    break;
                case 8:
                    Organize.SplitSelectedList(_listedCards);
                    break;
                default:
                    Display.MenuStatus = 0;
                    break;
            }
        }
    }
}
