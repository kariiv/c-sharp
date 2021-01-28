using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    interface IShape
    {
        void Draw();
    }

    class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am a triangle");
        }
    }

    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am a square");
        }
    }

    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am a circle");
        }
    }
}
