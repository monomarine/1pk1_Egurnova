using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_02
{
    /*
         Создать класс EventCalendar, который хранит события (Dictionary<DateOnly, List<string>>).
            Методы:
            AddEvent(DateOnly, string) - добавить событие
            GetEventsForDay(DateOnly) - получить события на день
            GetEventsForWeek(DateTime) - получить все события на неделю*/
    internal class EventCalendar
    {
        private Dictionary<DateOnly, List<string>> events = new();

        public void AddEvent(DateOnly date, string eventData)
        {
            if(!events.ContainsKey(date)) 
            {
                events[date] = new List<string>{eventData };  
            }
            else
                events[date].Add(eventData);
        }

        public List<string> GetEventsForDay(DateOnly date) 
        { 
            if(!events.ContainsKey(date))
            {
                Console.WriteLine($"событий на дату {date} нет");
                return null;
            }

            return events[date];
        }

        public void PrintEventsForDay(DateOnly date)
        {
            List<string> result = GetEventsForDay(date);
            Console.WriteLine($"---------события на {date}-----------");
            int n = 1;
            foreach (string res in result)
            {
                Console.WriteLine($"{n}: {res}");
                n++;
            }
        }

        public Dictionary<DateOnly, List<string>> GetEventsForWeek()//не работает
        {
            DateTime date = DateTime.Now;
            DateOnly weekStartDay = DateOnly.FromDateTime(date.AddDays(-(int)date.DayOfWeek));
            Console.WriteLine(weekStartDay);
            //  DateOnly weekEndDay = weekStartDay.AddDays(7);

            /* switch(date.DayOfWeek)
             {
                 case DayOfWeek.Monday:
                     weekStartDay = DateOnly.FromDateTime(date);
                     weekEndDay = weekStartDay.AddDays(6);
                     break;
                 case DayOfWeek.Tuesday: 

                     break;
                 case DayOfWeek.Wednesday:

                     break;
                 case DayOfWeek.Thursday:

                     break;
                 case DayOfWeek.Friday:

                     break;
                 case DayOfWeek.Saturday:

                     break;
                 case DayOfWeek.Sunday:

                     break;
             }
        */
            // пн вт ср чт пт сб вс
            Dictionary<DateOnly, List<string>> weekEvents = new();

            for(int i = 0; i< 7; i++)
            {
                if (!events.ContainsKey(weekStartDay))
                    continue;

                weekEvents[weekStartDay] = events[weekStartDay];

                weekStartDay = weekStartDay.AddDays(1);
            }

            return weekEvents;
        }

        public void PrintEventsForWeek()
        {
            var weekEvents = GetEventsForWeek();

            Console.WriteLine("-----------события на текущую неделю----------");
            
            foreach(KeyValuePair<DateOnly, List<string>> pair in weekEvents)
            {
                Console.WriteLine($"события на {pair.Key}:");
                foreach(string str in pair.Value)
                {
                    int n = 1;
                    Console.WriteLine($"{n}: {str}");
                    n++;
                }
            }
        }
    }
}
