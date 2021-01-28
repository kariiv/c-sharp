using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kauri_Riivik_178943IABB_Test
{
    class ShufflePlayer : PremiumDevice
    {
        public ShufflePlayer(string name, string warranty):base(name, warranty)
        {
            _maxList = 2147483647; //Int32 limit;
            mp3.Add("Despacito");
            mp3.Add("Gangnam Style");
            mp3.Add("All About That Bass");
        }

        public void ShuffledNext()
        {
            Random rnd = new Random();
            if (_deviceProgram == 1)
            {
                _playing = rnd.Next(0, mp3.Count());
                Mp3Now();
            }
        }
        public override void SwitchPlayMode()
        {
            base.SwitchPlayMode();
            if(_deviceProgram ==2 )
            {
                _deviceProgram = 1;
                Console.WriteLine("MP3 player is playing!");
            }
        }

        public void DVDMode() //Selecting DeviceProgram Shuffle play
        {
            if(_deviceProgram == 0 || _deviceProgram == 1)
            {
                _deviceProgram = 2;
                Console.WriteLine("Shuffle player is playing!");
            }
        }

        public void PlayDVD(string name) //Only if DeviceProgram set to 2
        {
            if(_deviceProgram == 2)
            {
                Console.WriteLine("Im playing the DVD: " + name);
            }
        }
    }
}
