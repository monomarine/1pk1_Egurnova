using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_01
{
    public enum Status { Low, Middle, Hight}
    internal class TestClass
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public  DateTime Date { get; set; } 
        public Status Status { get; set; }
    }
}
