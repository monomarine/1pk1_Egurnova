using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Square : IDrawable
    {
        private int width;
        private int height;
        public int Width
        {
            get => width;
            set
            {
                if (value > 1)
                    width = value;
                else
                    throw new ArgumentException("ширина не должна быть меньше или равна 1");
            }
        }
        public int Height
        {
            get => height;
            set
            {
                if(value > 1)
                    height = value;
                else
                    throw new ArgumentException("высота не должна быть меньше или равна 1");
            }
        }

        public Square (int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine();
            for (int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
