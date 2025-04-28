using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Wolf : Animal
    {
        public Wolf() : base("Волк") { }

        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Волк тоже не справился
        }
    }
}
