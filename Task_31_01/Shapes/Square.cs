using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shapes
{
    internal class Square : Shape
    {
        public double Side { get; }
        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetPerimetr()
        {
            return 4 * Side;
        }
    }
}
