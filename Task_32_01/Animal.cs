using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public abstract class Animal
    {
        public string Name { get; } //название животного

        //конструктор, который будет срабатывать в дочерних классах
        //т.к. используется protected
        protected Animal(string name)
        {
            Name = name;
        }
        //все животные захотят съесть колобка
        //но вот получится ли - вопрос...
        public abstract bool CanEat(Kolobok kolobok);
    }
}
