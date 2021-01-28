using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ShapeFactory
    {
        //is responsible for creating the objects
        public IShape GetShape(int numberOfCorners)
        {
            if (numberOfCorners == 3)
            {
                return new Triangle();
            }
            else if (numberOfCorners == 4)
            {
                return new Square();
            }
            else if (numberOfCorners == 0)
            {
                return new Circle();
            }
            else
            {
                return null;
            }
        }

    }
}
