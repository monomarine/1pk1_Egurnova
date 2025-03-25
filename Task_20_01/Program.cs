namespace Task_20_01
{
    internal class Program
    {
        /*Создайте enum для дней недели (Monday–Sunday). 
         * Напишите программу, которая:
            Принимает от пользователя число (1–7).
            Преобразует его в день недели.
            Выводит сообщение:
            "Будний день" (для Monday–Friday).
            "Выходной" (для Saturday, Sunday).
            */

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("введите порядковый номер дня недели");
                int userDay = Convert.ToInt32(Console.ReadLine());
                WeekDay day = (WeekDay)userDay;

                switch (day)
                {
                    case WeekDay.Monday:
                    case WeekDay.Tuesday:
                    case WeekDay.Wednesday:
                    case WeekDay.Thursday:
                    case WeekDay.Friday:
                        Console.WriteLine($"будний день - {day}");
                        break;
                    case WeekDay.Saturday:
                    case WeekDay.Sunday:
                        Console.WriteLine($"выходной день - {day}");
                        break;
                    default:
                        Console.WriteLine("число должно быть строго в диапазоне от 1 до 7");
                        break;
                }
            }
        }
    }
}
