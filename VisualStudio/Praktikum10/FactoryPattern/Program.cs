using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DogFactory dogfac = new DogFactory();

            IDog dog1 = dogfac.GetDog("small");
            dog1.Speak();

            IDog dog2 = dogfac.GetDog("big");
            dog2.Speak();

            IDog dog3 = dogfac.GetDog("working");
            dog3.Speak();

            IDog dog4 = dogfac.GetDog("lalala"); //returns null
            try 
            {
                dog4.Speak();
            }
            catch { }

            Console.ReadLine();

        }
    }
}
