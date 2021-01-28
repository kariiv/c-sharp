using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IDReader
{
    class IDReader
    {
        private string _birthArea;
        private string _birthDay;
        private int _checkNumber;
        private string _idCode;
        private string _sex;
        public string _destinationFileRead = @"IDCodeRead.txt";
        private string _destinationFileWrite = @"IDCodeWrite.txt";

        public IDReader()
        {
            _sex = "Mees";
            _birthDay = "01.01.1999";
            _birthArea = "Tallinn";
            _checkNumber = 0;
            _idCode = null;
        }

        public IDReader(string IDCode)
        {
            _idCode = IDCode;
            Decoder();
        }

        public void Decoder()
        {
            if (_idCode[0].ToString() == "2" || _idCode[0].ToString() == "4" || _idCode[0].ToString() == "6")
            {
                _sex = "Naine";
            }
            else if (_idCode[0].ToString() == "1" || _idCode[0].ToString() == "3" || _idCode[0].ToString() == "5")
            {
                _sex = "Mees";
            }
            else
            {
                _sex = "Invalid";
            }

            string day = null;
            string month = null;
            string year = null;
            if (_idCode[0].ToString() == "1" || _idCode[0].ToString() == "2")
            {
                year = "18" + _idCode[1].ToString() + _idCode[2].ToString();
            }
            else if (_idCode[0].ToString() == "3" || _idCode[0].ToString() == "4")
            {
                year = "19" + _idCode[1].ToString() + _idCode[2].ToString();
            }
            else if (_idCode[0].ToString() == "5" || _idCode[0].ToString() == "6")
            {
                year = "20" + _idCode[1].ToString() + _idCode[2].ToString();
            }
            else if (_idCode[0].ToString() == "7" || _idCode[0].ToString() == "8")
            {
                year = "21" + _idCode[1].ToString() + _idCode[2].ToString();
            }

            day = _idCode[5].ToString() + _idCode[6].ToString();
            month = _idCode[3].ToString() + _idCode[4].ToString();
            _birthDay = day + "." + month + "." + year;

            int place = Convert.ToInt16(_idCode[7].ToString() + _idCode[8].ToString() + _idCode[9].ToString());
            if (place <= 10)
            {
                _birthArea = "Kuressaare Haigla";
            }
            else if (place <= 19)
            {
                _birthArea = "Tartu Ülikooli Naistekliinik, Tartumaa, Tartu";
            }
            else if (place <= 220)
            {
                _birthArea = "Ida-Tallinna Keskhaigla, Pelgulinna sünnitusmaja, Hiiumaa, Keila, Rapla haigla, Loksa haigla";
            }
            else if (place <= 270)
            {
                _birthArea = " Ida-Viru Keskhaigla (Kohtla-Järve, endine Jõhvi)";
            }
            else if (place <= 370)
            {
                _birthArea = "Maarjamõisa Kliinikum (Tartu), Jõgeva Haigla";
            }
            else if (place <= 420)
            {
                _birthArea = "Narva Haigla";
            }
            else if (place <= 470)
            {
                _birthArea = "Pärnu Haigla";
            }
            else if (place <= 490)
            {
                _birthArea = "Pelgulinna Sünnitusmaja (Tallinn), Haapsalu haigla";
            }
            else if (place <= 520)
            {
                _birthArea = "Järvamaa Haigla (Paide)";
            }
            else if (place <= 570)
            {
                _birthArea = "Rakvere, Tapa haigla";
            }
            else if (place <= 600)
            {
                _birthArea = "Valga Haigla";
            }
            else if (place <= 650)
            {
                _birthArea = "Viljandi Haigla";
            }
            else if (place <= 710)
            {
                _birthArea = "Lõuna-Eesti Haigla (Võru), Põlva Haigla";
            }
            else if (place <= 999)
            {
                _birthArea = "Teadmata";
            }

            _checkNumber = Int16.Parse(_idCode[10].ToString());
        }

        public void InfoPrint()
        {
            Console.WriteLine("ID code {0}\nSugu: {1}\nSünnikuupäev: {2}\nSünnikoht: {3}\nKontrollnumber: {4}\n", _idCode, _sex, _birthDay, _birthArea, _checkNumber);
        }

        public void SaveIDInfo()
        {
            using (StreamWriter writer = new StreamWriter(_destinationFileWrite, true))
            {
                writer.WriteLine("ID code {0} * Sugu: {1} * Sünnikuupäev: {2} * Sünnikoht: {3} * Kontrollnumber: {4} *", _idCode, _sex, _birthDay, _birthArea, _checkNumber);
            }
        }

        public void CreateNewIdCode(DateTime birthDay, string place, string sex, int checkNumber)
        {
            _birthArea = place;
            _sex = sex;
            _checkNumber = checkNumber;
            _birthDay = birthDay.ToString();

            if (sex == "Mees" || sex == "mees")
            {
                if (_birthDay[6].ToString() == "8")
                {
                    _idCode = "1";
                }
                else if (_birthDay[6].ToString() == "9")
                {
                    _idCode = "3";
                }
                else if (_birthDay[6].ToString() == "0")
                {
                    _idCode = "5";
                }
            }
            else if (sex == "Naine" || sex == "naine")
            {
                if (_birthDay[6].ToString() == "8")
                {
                    _idCode = "2";
                }
                else if (_birthDay[6].ToString() == "9")
                {
                    _idCode = "4";
                }
                else if (_birthDay[6].ToString() == "0")
                {
                    _idCode = "6";
                }
            }
            if (_birthDay[1].ToString() == ".")
            {
                _idCode += _birthDay[7].ToString() + _birthDay[8].ToString() + _birthDay[2].ToString() + _birthDay[3].ToString() + "0" + _birthDay[0].ToString();
            }
            if (_birthDay[2].ToString() == ".")
            {
                _idCode += _birthDay[8].ToString() + _birthDay[9].ToString() + _birthDay[3].ToString() + _birthDay[4].ToString() + _birthDay[0].ToString() + _birthDay[1].ToString();
            }

            switch (place)
            {
                case "Kuressaare":
                    _idCode += "001";
                    break;

                case "Tartu":
                    _idCode += "011";
                    break;

                case "Ida-Tallinna":
                    _idCode += "021";
                    break;
                case "Pelgulinna":
                    _idCode += "021";
                    break;
                case "Hiiumaa":
                    _idCode += "021";
                    break;
                case "Keila":
                    _idCode += "021";
                    break;
                case "Rapla":
                    _idCode += "021";
                    break;
                case "Loksa":
                    _idCode += "021";
                    break;

                case "Ida-Viru":
                    _idCode += "221";
                    break;
                case "Kohtla-Järve":
                    _idCode += "221";
                    break;
                case "Jõhvi":
                    _idCode += "221";
                    break;

                case "Maarjamõisa":
                    _idCode += "271";
                    break;
                case "Jõgeva":
                    _idCode += "271";
                    break;

                case "Narva":
                    _idCode += "371";
                    break;

                case "Pärnu":
                    _idCode += "421";
                    break;

                case "Haapsalu":
                    _idCode += "471";
                    break;

                case "Järvamaa":
                    _idCode += "491";
                    break;
                case "Paide":
                    _idCode += "491";
                    break;

                case "Rakvere":
                    _idCode += "521";
                    break;
                case "Tapa":
                    _idCode += "521";
                    break;

                case "Valga":
                    _idCode += "571";
                    break;

                case "Viljandi":
                    _idCode += "650";
                    break;

                case "Lõuna-Eesti":
                    _idCode += "651";
                    break;
                case "Võru":
                    _idCode += "651";
                    break;
                case "Põlva":
                    _idCode += "651";
                    break;
                default:
                    _idCode += "000";
                    break;
            }

            _idCode += _checkNumber;
        }
    }
}
