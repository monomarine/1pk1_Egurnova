namespace Task_22_01
{
    internal class Program
    {
        /*Создать класс WorkDay, который хранит дату (DateOnly) и времена начала/окончания работы (TimeOnly).
        Методы:
        GetDuration() - возвращает TimeSpan продолжительности рабочего дня
        AddBreak(TimeSpan) - добавляет перерыв к рабочему дню*/
        static void Main(string[] args)
        {
            WorkDay day1 = new WorkDay(new DateOnly(2025, 03, 29), new TimeOnly(10, 00), new TimeOnly(16, 00));
            Console.WriteLine($"продолжительность рабочего дня без учета перерыва - {day1.GetDuration()} часов");

            day1.AddBreak(new TimeSpan(1, 0, 0));
            Console.WriteLine($"продолжительность рабочего дня с учетом перерыва - {day1.GetDuration()} часов");
        }
    }
}
