using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    interface IDog
    {
        void Speak();
    }

    class Poodle : IDog
    {
        public void Speak()
        {
            Console.WriteLine("The poodle says \"arf\"");
        }

    }
    class Rottweiler : IDog
    {
        public void Speak()
        {
            Console.WriteLine("The Rottweiler says (in a very deep voice) \"WOOF!\"");
        }

    }
    class SiberianHusky : IDog
    {
        public void Speak()
        {
            Console.WriteLine("The husky says \"Dude, what's up?\"");
        }

    }

}
