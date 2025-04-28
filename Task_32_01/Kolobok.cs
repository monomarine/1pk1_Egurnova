using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; }
        public bool IsAlive { get; private set; }

        public Kolobok()
        {
            Position = 0;
            Speed = 1;
            IsAlive = true;
        }

        public void Roll()
        {
            Position += Speed;
            Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
        }

        public void MeetAnimal(Animal obstacle)
        {
            if (obstacle.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {obstacle.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {obstacle.Name}!");
            }
        }
    }
}
