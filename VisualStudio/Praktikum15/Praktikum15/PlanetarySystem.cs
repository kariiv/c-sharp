using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum15
{
    class PlanetarySystem
    {
        Planet[] planets;

        public PlanetarySystem()
        {
            planets = new Planet[8];

            Planet planetMercury = new Planet("Mercury", 4222.6, 0.33, 1);

            planets[0] = planetMercury;

            Planet planetVenus = new Planet("Mercury");

            planets[0] = planetVenus;

        }

        public PlanetarySystem(int planetCount)
        {
            planets = new Planet[planetCount];

            for (int i = 0; i < planetCount; i++)
            {
                if (i == 0)
                    planets[0] =;
                if(i == 1)

            }

        }

        public void PrintAllPlanetsInfo()
        {
            foreach(Planet name in planets)
            {

            }
        }


    }
}
