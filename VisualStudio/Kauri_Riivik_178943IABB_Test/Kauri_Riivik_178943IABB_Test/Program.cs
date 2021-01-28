using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


namespace Kauri_Riivik_178943IABB_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardDevice standard1 = new StandardDevice("MassPlayer");
            StandardDevice standard2 = new StandardDevice("ModerMusic");

            PremiumDevice premium1 = new PremiumDevice("PremQuality", "kioe11f2ef22e");
            PremiumDevice premium2 = new PremiumDevice("NiceSound", "567fyidf2ef99");

            ShufflePlayer shuffle = new ShufflePlayer("BestMusic", "ju778488h2f29hd");
            Console.WriteLine("STANDARD DEVICE:");
            standard1.RadioNow();
            standard1.SetFrequencies(89);
            standard1.RadioNow();

            standard2.RadioNow();
            standard2.SetFrequencies(84); //ErrorCheck
            standard2.RadioNow();

            standard1.Mp3Now(); //Must not print anything!
            Console.WriteLine("");
            standard2.SwitchPlayMode(); //To Mp3

            standard2.Mp3Now();
            standard2.Mp3Next(); //next includes "MP3Now()" Shows automatically next song!
            standard2.Mp3Next();
            standard2.Mp3Next();
            standard2.Mp3Next(); //Starts from the beginning
            standard2.StoredSongs();
            standard2.DeviceInfo();
            
            Console.WriteLine("\nPREMIUM DEVICE:");

            premium1.RadioNow();
            premium1.SetFrequencies(106);
            premium1.RadioNow();

            premium2.RadioNow();
            premium2.SetFrequencies(108); //ErrorCheck
            premium2.RadioNow();

            premium1.Mp3Now(); //Must not print anything!
            Console.WriteLine("");
            premium2.SwitchPlayMode(); //To Mp3

            premium2.Mp3Now();
            premium2.Mp3Next(); //next includes "MP3Now()" Shows automatically next song!
            premium2.Mp3Next();
            premium2.Mp3Next();
            premium2.Mp3Next();
            premium2.Mp3Next();
            premium2.Mp3Next();//Starts from the beginning
            premium2.StoredSongs();
            premium2.DeviceInfo();
            premium1.DeviceInfo();

            Console.WriteLine("\nSHUFFLE PLAYER");
            shuffle.SwitchPlayMode();
            shuffle.Mp3Now();
            shuffle.ShuffledNext();//automatically displays the name of a song
            shuffle.ShuffledNext();
            shuffle.ShuffledNext();
            shuffle.ShuffledNext();
            shuffle.DeviceInfo();
            shuffle.DVDMode();
            shuffle.PlayDVD("Old Best!"); //DVD test

            shuffle.Mp3Now(); //Must not do anything!
            shuffle.SetFrequencies(100); //Must not do anything!

            shuffle.SwitchPlayMode();  //testing Switching 
            shuffle.Mp3Now();
            shuffle.ShuffledNext(); //Works Fine!

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.WriteLine("GoodBye!");
            Thread.Sleep(3000);
        }
    }
}
