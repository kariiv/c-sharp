using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CinemaPlacement
{
    public class Functsions
    {
        private string[,] _seats;
        private readonly string _path = "Cinema_Seats.txt";
        public int NumberOfSeats;
        public string Username;
        public void SetNumberOfSeats(int seats) {
            _seats = new string[seats,2];
            NumberOfSeats = seats;
        }
        public void ReadSeatsFromDatabase() {
            // [0 free; 1 busy; 2 sold] [name]; 
            using (StreamReader reader = new StreamReader(_path)) {
                string line;
                int seat = 0;
                while (seat < NumberOfSeats) {
                    line = reader.ReadLine() ?? "0";
                    if (line.Length == 1)
                        _seats[seat, 0] = line;
                    else if (line.Length > 1) {
                        string[] seatPlace = line.Split('\t');
                        _seats[seat, 0] = seatPlace[0];
                        _seats[seat, 1] = seatPlace[1];
                    }
                    seat += 1;
                }
            }
        }
        public bool CheckLength(string word) {
            return word.Length <= 15;
        }
        public void WriteSeatsToDatabase() {
            using (StreamWriter writer = new StreamWriter(_path, true)) {
                for (int i = 0; i < _seats.Length / 2; i++) {
                    writer.WriteLine(_seats[i, 0] + "\t" + _seats[i, 1]);
                }
            }
        }
        public int CheckSeat(string seatName, bool hover) {
            int seatData = int.Parse(_seats[StringLastInt(seatName)-1, 0] ?? "0");
            if (seatData == 0 && !hover)
                return 2; //free
            else if (seatData == 0)
                return 1; //select
            else if (seatData == 1) {
                return 3; //busy
            }
            else {
                if (IsTheOwner(seatName))
                return 0; //my seat
                else {
                    return 4; //sold
                }
            }
        }
        private bool IsTheOwner(string seat) {
            return _seats[StringLastInt(seat) - 1, 1] == Username;
        }
        public int StringLastInt(string seatName) {
            if (int.TryParse(seatName.Substring(seatName.Length - 3, 3), out var number))
                return number;
            else if (int.TryParse(seatName.Substring(seatName.Length - 2, 2), out number))
                return number;
            else if (int.TryParse(seatName.Substring(seatName.Length - 1), out number))
                return number;
            return 0;
        }
        public void BuyingSystem(int seatNumber) {
            _seats[seatNumber - 1, 0] = "2";
            _seats[seatNumber - 1, 1] = Username;
        }
        public void CancelOrder(int seatInDataBase) {
            if (Username == _seats[seatInDataBase, 1]) {
                _seats[seatInDataBase, 0] = null;
                _seats[seatInDataBase, 1] = null;
            }

        }
    }
}