using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Fox : Animal
    {
        public Fox() : base("Лиса") { }

        public override bool CanEat(Kolobok kolobok)
        {
            return true; // Лиса хитрая и съела Колобка
        }
    }
}
