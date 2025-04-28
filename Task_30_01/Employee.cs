using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_30_01
{
    internal class Employee : Person
    {
        public string Position { get; set; } //должность



        public void ChangePosition(string position)
        {
            this.Position = position;
        }
    }
}
