using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_02
{
    internal class Car
    {
        public string StateNomer {  get; set; }   
        public int CurrentSpeed { get; set; }
        public static int MaxSpeed { get; set; } = 60; 

        public Car(string stateNomer, int currentSpeed)
        {
            StateNomer=stateNomer;
            CurrentSpeed=currentSpeed;
        }

        public void Drive(int delta)
        {
            for(int i = 0;i < 20; i++)
            {
                if (CurrentSpeed >= MaxSpeed)
                {
                    Logger.Write($"{StateNomer} ПРЕВЫШЕНИЕ СКОРОСТИ!", MessageType.HIGHT);
                    break;
                }
                else
                {
                    CurrentSpeed += delta;
                    Logger.Write($"текущая скорость автомобиля{StateNomer} - {CurrentSpeed}", MessageType.LOW);
                }
            }
        }
    }
}
