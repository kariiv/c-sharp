using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class DogFactory
    {
        //is responsible for creating the objects
        public IDog GetDog(string criteria)
        {
            if (criteria == "small")
            {
                return new Poodle();
            }
            else if (criteria == "big")
            {
                return new Rottweiler();
            }
            else if (criteria == "working")
            {
                return new SiberianHusky();
            }
            else
            {
                return null;
            }
        }
    }
}
