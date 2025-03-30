using System.Diagnostics;
using System.Net.Http.Headers;

namespace Task_22_03
{
    internal class Program
    {
        /*
         Создать класс CustomTimer, который измеряет временные промежутки.
            Методы:
            Start() - начать отсчёт
            Stop() - остановить и вернуть TimeSpan
            Pause() / Resume() - управление паузой

         */
        static void Main(string[] args)
        {
            CustomTimer.Start();
            Thread.Sleep(3000); // + 3 секунды

            CustomTimer.Pause();
            Thread.Sleep(3000); //пауза 3 секунды

            CustomTimer.Resume();
            Thread.Sleep(2000); // + 2 секунды

            CustomTimer.Pause();
            Thread.Sleep(2000); //пауза 2 секунды

            CustomTimer.Resume();
            Thread.Sleep(3000); // + 3 секунды

            CustomTimer.Pause();
            Thread.Sleep(2000); // паузда 2 секунды

            CustomTimer.Resume();
            Thread.Sleep(3000); // + 3 секунды

            CustomTimer.Stop();// итого прошло 18 секунд из которых таймер насчитал 11

            Console.WriteLine(CustomTimer.SecondsDuration.ToString("F0"));
        }
    }
}
