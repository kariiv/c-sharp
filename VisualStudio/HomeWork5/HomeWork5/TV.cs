using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class TV
    {
        private int _Volume;
        private bool _System;
        private int _Channel;

        public TV()
        {
            _Volume = 0;
            _Channel = 0;
            _System = false;
        }

        public void System(int n)
        {
            Console.Clear();
            if (_System && n == 0)
            {
                 _System = true;
                Yellow("TV is turned on!");
            }
            else if (_System && n == 0)
            {
                _System = false;
                Yellow("TV is turned off!");
            }

            if (_System)
            {
                if (n == 1 || n == 2 || n == 3 || n == 4) // VolumeChanger && ChannelChanger
                {
                    AddVolume(n);
                    Channel(n);
                }
                PrintChannel();
                PrintVol();
            }
        }

        private void AddVolume(int trigger)
        {
            if (trigger == 1 && _Volume < 15)
            {
                _Volume += 3;
            }
            else if (trigger == 2 && _Volume > 0)
            {
                _Volume -= 3;
            }
        }
        private void Channel(int trigger)
        {
            if (trigger == 3 && _Channel < 100)
            {
                _Channel++;
            }
            else if (trigger == 4 && _Channel > 0)
            {
                _Channel--;
            }
        }

        private void PrintVol()
        {
            if(_Volume == 15)
            {
                Yellow(_Volume + " - max vol.");
            }
            else if (_Volume ==0)
            {
                Yellow(_Volume + " - min vol.");
            }
            else
            {
                Yellow(_Volume + "vol.");
            }
        }
        private void PrintChannel()
        {
            if (_Channel == 100)
            {
                Yellow(_Channel + ". last channel");
            }
            else if (_Channel == 0)
            {
                Yellow(_Channel + ". first channel");
            }
            else
            {
                Yellow(_Channel + ". channel");
            }
        }

        public void Yellow(string print)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(print);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
