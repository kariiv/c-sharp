using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    interface IShapes
    {
        void Draw();
    }
    class Triangle
    {
        public void Draw()
        {
            Console.WriteLine("I am a Triangle");
        }
    }

    class Square
    {
        public void Draw()
        {
            Console.WriteLine("I am a Square");
        }
    }
    class Circle
    {
        public void Draw()
        {
            Console.WriteLine("I am a Circle");
        }
    }




    class ShapeFactory
    {
        public IShapes GetShapes(int numberOfCorners)
        {
            if (numberOfCorners == 3)
                return new Square;
        }
    }
}
