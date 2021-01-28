using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory sf = new ShapeFactory();

            IShapes shape1 = sf.GetShapes(3);
            shape1.Draw();
        }
    }
}
