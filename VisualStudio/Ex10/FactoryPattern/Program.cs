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
            ShapeFactory sf = new ShapeFactory();

            IShape shape1 = sf.GetShape(3);
            shape1.Draw();

            IShape shape2 = sf.GetShape(4);
            shape2.Draw();

            IShape shape3 = sf.GetShape(0);
            shape3.Draw();
        }
    }
}
