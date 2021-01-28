using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum8
{
    class Bus
    {
        int NrOfPeople;
        int NrOfBuses;

        public void FindNumbers(int people, int seats)
        {
            NrOfBuses = 1;
            while(people > seats)
            {
                people -= seats;
                NrOfBuses += 1;
            }
            NrOfPeople = people;
        }

        public int GetNrOfPeople()
        {
            return NrOfPeople;
        }

        public int GetNrOfBuses()
        {
            return NrOfBuses;
        }




    }
}
