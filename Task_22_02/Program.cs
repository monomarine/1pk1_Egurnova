using System.Globalization;

namespace Task_22_02
{
    internal class Program
    {
        /*
         Создать класс EventCalendar, который хранит события (Dictionary<DateOnly, List<string>>).
            Методы:
            AddEvent(DateOnly, string) - добавить событие
            GetEventsForDay(DateOnly) - получить события на день
            GetEventsForWeek(DateTime) - получить все события на неделю*/
        static void Main(string[] args)
        {
          // CultureInfo.CurrentCulture = new CultureInfo("en-EN");
            EventCalendar eventCalendar = new EventCalendar();

            eventCalendar.AddEvent(new DateOnly(2025, 03, 25), "День смеха");
            eventCalendar.AddEvent(new DateOnly(2025, 03, 25), "зачет по программированию");

            //eventCalendar.PrintEventsForDay(new DateOnly(2025, 04, 01));

            DateOnly date1 = new DateOnly(2025, 03, 26);
            DateOnly date2 = new DateOnly(2025, 03, 28);

            eventCalendar.AddEvent(date1, "тренировка по баскетболу");
            eventCalendar.AddEvent(date2, "старостат");

            //eventCalendar.PrintEventsForDay(date1);
            //eventCalendar.PrintEventsForDay(date2);

            eventCalendar.PrintEventsForWeek();

           
        }
    }
}
