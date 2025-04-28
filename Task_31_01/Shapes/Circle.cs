using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Shapes
{
    internal sealed class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius) => Radius = radius;
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimetr()
        {
            return 2 * Math.PI * Radius;
        }
    }

}
