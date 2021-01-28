using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3
{
    class Person
    {
        public Person()
        {
            _name = "unknown";
            _age = 0;
        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        private string _name;
        private int _age;


        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetAge(int age)
        {
            _age = age;
            Console.WriteLine("Set age value " + _age);
        }

        public int GetAge()
        {
            return _age;
        }

        public void SetAge(DateTime birthYear)
        {
            _age = DateTime.Today.Year - birthYear.Year;
        }

        public void SetAge(string value)
        {
            if(value.Length == 4)
            {
                SetAge(new DateTime(int.Parse(value), 1, 1));
            }
            else if (value.Length > 0 && value.Length < 4)
            {
                SetAge(int.Parse(value));
            }
            else
            {
                Console.WriteLine("Can't set age, value invalid!");
                _age = 0;
            }
        }

    }
}
