using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_06
{
    internal class Car
    {
        public string Nomer { get; set; }
        public ConsoleColor Color { get; set; }
        public string Ouner { get; set; }   
        public Car(string nomer, ConsoleColor color, string ouner   )
        {
            Nomer=nomer;
            Color=color;
            Ouner=ouner;
        }
    }
}
