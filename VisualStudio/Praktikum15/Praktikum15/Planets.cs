using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum15
{
    class Planet
    {
        private string _Name;
        private double _Weight, _DayInHours, _YearInEarthYears, _YearInLocalSolarDays;
        int _NumberOfLandingPlatforms;
        SpaceShips[] _ShipsOnPlanet;

        public Planet(string planetName, double dayInHours, double weight, int numberOfLandingPlatforms )
        {
            _Name = planetName;
            _DayInHours = dayInHours;
            _NumberOfLandingPlatforms = numberOfLandingPlatforms;
            _Weight = weight;
        }

        public void PrintPlanetInfo()
        {
            Console.WriteLine("Planet {0} is  ",_Name, _DayInHours, _YearInEarthYears, _YearInLocalSolarDays);
        }

        public void PrintSpaceshipsInfo()
        {
            foreach(SpaceShips name in _ShipsOnPlanet)
            {
                name.
            }
        }
        
        public void CalculateYearInEarthYears()
        {

        }

        public void CalculateYearInLocalSolarDays()
        {

        }

    }
}
