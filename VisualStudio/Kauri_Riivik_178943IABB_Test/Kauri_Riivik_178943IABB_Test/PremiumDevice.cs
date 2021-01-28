using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kauri_Riivik_178943IABB_Test
{
    class PremiumDevice : StandardDevice
    {
        internal string _warranty;
        public PremiumDevice(string name, string warranty):base(name)
        {
            _warranty = warranty;
            _radioFrqMin = 85;
            _radioFrqMax = 107;
            _radioFrqStep = 2;
            _maxList = 5; //mp3 player maximum list length
            mp3.Add("Move");
            mp3.Add("Radioactive");
        }

        public override void DeviceInfo()
        {
            base.DeviceInfo();
            Console.WriteLine("Warranty code: " + _warranty);
        }
    }
}
