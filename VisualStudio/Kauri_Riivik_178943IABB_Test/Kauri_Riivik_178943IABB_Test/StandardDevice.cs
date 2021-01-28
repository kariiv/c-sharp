using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kauri_Riivik_178943IABB_Test
{
    class StandardDevice
    {
        internal string _deviceName;
        internal int _deviceProgram; //0=radio / 1=Mp3 /3=DVD (only Shuffle player)
        internal int _frequency;
        internal int _playing; //MP3 currently playing song in list
        internal int _maxList; //mp3 player maximum list length
        internal int _radioFrqMin; //Minimum Frequency
        internal int _radioFrqMax; //maximum Frequency
        internal int _radioFrqStep; //Step when Changing the Frequency
        internal List<string> mp3 = new List<string>();
        
        public StandardDevice(string name)
        {
            _deviceName = name;
            _radioFrqMin = 85;
            _frequency = 85;
            _radioFrqMax = 100;
            _radioFrqStep = 1;
            _deviceProgram = 0;
            _playing = 0;
            _maxList = 3; //mp3 player maximum list length
            mp3.Add("Satisfaction");
            mp3.Add("Thunder");
            mp3.Add("Pen Pineapple Apple pen");
        }
        public void SetFrequencies(int frequencie)
        {
            if (_deviceProgram == 0 && frequencie >= _radioFrqMin && frequencie <= _radioFrqMax) //depence on the minFrequency and maxFrequency
            {
                _frequency = frequencie;
                Console.WriteLine("Sets the frequency to " + _frequency);
            }
            else if (_deviceProgram ==  0)
                Console.WriteLine("Not in range from {0} to {1}", _radioFrqMin, _radioFrqMax);
        }
        public void AddFrequences() //Add frequency by step
        {
            if (_deviceProgram == 0 && _radioFrqMax > _frequency - _radioFrqStep)
            {
                _frequency += _radioFrqStep;
                Console.WriteLine("Changed frequency to " + _frequency);
            } 
            else if (_deviceProgram == 0)
                Console.WriteLine("{0} is the highest frequency", _radioFrqMax);
        }
        public void DevFrequences() //Remove frquency by step
        {
            if (_deviceProgram == 0 && _radioFrqMin < _frequency - _radioFrqStep)
            {
                _frequency -= _radioFrqStep;
                Console.WriteLine("Changed frequency to " + _frequency);
            }
            else if (_deviceProgram == 0)
                Console.WriteLine("{0} is the lowest frquency", _radioFrqMin);
        }

        public virtual void SwitchPlayMode() //Switch the radio and mp3. Radio = true / Mp3 = false
        {
            if (_deviceProgram == 1)
            {
                _deviceProgram = 0;
                Console.WriteLine("Radio is playing!");
            }
            else if (_deviceProgram == 0)
            {
                _deviceProgram = 1;
                Console.WriteLine("MP3 player is playing!");
            }
        }
        public void Mp3Now() //Displays MP3 status
        {
            if (_deviceProgram == 1)
            {
                Console.WriteLine("{1}\nIm playing as music player\nCurrenty playing: {0}",mp3[_playing], _deviceName);
            }
        }
        public void RadioNow() //Displays Radio status
        {
            if (_deviceProgram == 1)
            {
                Console.WriteLine("{1}\nIm playing as a radio\nFrequency: {0}", _frequency, _deviceName);
            }
        }
        public void StoredSongs()
        {
            int i = 1; //counts songs
            Console.WriteLine("List of all songs in {0}:", _deviceName);
            foreach(string c in mp3)
            {
                Console.WriteLine("{0}. {1}",i,c);
                i++;
            }
        }
        public virtual void DeviceInfo()
        {
            Console.WriteLine("Device name: {0}\nSongs stored: {1}",_deviceName, mp3.Count());
        }


        public void Mp3Next() //switch to the next song
        {
            if (_deviceProgram == 1)
            {
                _playing +=1;
                if (_playing == _maxList)
                    _playing = 0;
                Mp3Now();
            }
        }



    }
}
