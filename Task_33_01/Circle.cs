using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Circle : IDrawable
    {
        private int radius;
        public int Radius
        {
            get => radius;
            set
            {
                if (value < 1)
                    throw new ArgumentException("радиус должен быть больше 1");
                else radius = value;
            }
        }

        public Circle(int rad)
        {
            Radius = rad;
        }

        public void Draw()
        {
         
            for (int x = -Radius; x <= Radius; x++)
            {
                for(int y = -Radius; y <= Radius; y++)
                {
                    if(y*y + x*x <= Radius * Radius)
                        
                        Console.Write("**");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
