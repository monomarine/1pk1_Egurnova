using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_03
{
    /*
         Создать класс CustomTimer, который измеряет временные промежутки.
            Методы:
            Start() - начать отсчёт
            Stop() - остановить и вернуть TimeSpan
            Pause() / Resume() - управление паузой

         */
    internal static class CustomTimer
    {
        private static TimeSpan duration = TimeSpan.Zero;
        private static DateTime start;

        private static bool isRunning = false;
        private static bool isPaused = false;   

        public static double MinutesDuration => duration.TotalMinutes;
        public static double SecondsDuration => duration.TotalSeconds;
        public static TimeSpan Duration => duration;


        public static void Start()
        {
            if (!isRunning)
            {
                duration = TimeSpan.Zero; //обнуление насчитанного времени
                start = DateTime.Now; //получение текущего времени
                isRunning = true; //перевод флажка в состояние подсчета
            }
            else
                Console.WriteLine("Таймер уже запущен. дождитесь окончания");
        }

        public static void Stop() 
        {
            if (isRunning)//остановка только в случае запущенного таймера
            {
                duration += DateTime.Now - start; //вычиляет разницу между временем остановки и временем старта
            }
            else
                Console.WriteLine("Таймер не запущен");
        }

        public static void Pause()
        {
            if (isRunning)//пауза возможна только во время работы таймера
            {
                isPaused = true;//вкл флага паузы
                duration += DateTime.Now - start; //дозапись к отсчитанному времени пройденного временного промежутка
                start = DateTime.Now; //в start записывается текущее время, чтобы потом отсчет считался от него
            }
        }
        public static void Resume()
        {
            if(isPaused)
            {
                duration -= DateTime.Now - start;
                isPaused = false;
            }
        }
    }
}
