using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum15
{
    interface ISpaceShip
    {
        void Travel(int destinationplanetID);
    }

    class SpaceShips : ISpaceShip
    {
        string _SpaceshipName;
        int destinationID;

        public SpaceShips(string Name)
        {
            _SpaceshipName = Name;
            destinationID = 2;
        }

        public void PrintSpaceshipName()
        {
            
        }

        public void Travel(int ID)
        {

        }



    }
}
