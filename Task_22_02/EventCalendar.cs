using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_02
{
            /*класс EventCalendar, который хранит события (Dictionary<DateOnly, List<string>>).
            Методы:
            AddEvent(DateOnly, string) - добавить событие
            GetEventsForDay(DateOnly) - получить события на день
            GetEventsForWeek(DateTime) - получить все события на неделю */
    internal class EventCalendar
    {
        private Dictionary<DateOnly, List<string>> events = new(); //словарь со всеми событиями

        /// <summary>
        /// добавление события на конкретную дату
        /// </summary>
        /// <param name="date"></param>
        /// <param name="eventData"></param>
        public void AddEvent(DateOnly date, string eventData)
        {
            if(!events.ContainsKey(date)) //если ключ в словаре (нужная дата) не существует
            {
                events[date] = new List<string>{eventData };  //то по этому ключу создать новый список с записью eventData
            }
            else //если ключ уже есть
                events[date].Add(eventData); //то в список по этому ключу дописать новое событие
        }

        /// <summary>
        /// вывод всех событий на конкретный день
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<string> GetEventsForDay(DateOnly date) 
        { 
            if(!events.ContainsKey(date))
            {
                Console.WriteLine($"событий на дату {date} нет");
                return null;
            }
            //воврат списка событий по ключу date
            return events[date];
        }

        /// <summary>
        /// вывод на консоль событий на дату
        /// </summary>
        /// <param name="date"></param>
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

        /// <summary>
        /// получение списка всех событий на текущую неделю
        /// </summary>
        /// <returns></returns>
        public Dictionary<DateOnly, List<string>> GetEventsForWeek()
        {
            DateTime date = DateTime.Now; //получение текущей даты
            DateTime mondayDate = date.AddDays(-(int)date.DayOfWeek+1); //получение даты понедельника на текущей неделе (+1 нужен т.к. неделе здесь начинается в вск а мы считаем с понедельника
            DateOnly weekStartDay = DateOnly.FromDateTime(mondayDate);
            Console.WriteLine(weekStartDay);
           
            Dictionary<DateOnly, List<string>> weekEvents = new(); //пустой словарик для всех событий недели

            for(int i = 0; i< 7; i++) //7 итераций = кол-во дней в неделе
            {
                if (events.ContainsKey(weekStartDay)) //если в словаре есть нужная дата
                    weekEvents[weekStartDay] = events[weekStartDay];//то список копируется в результирующий словарь

                weekStartDay = weekStartDay.AddDays(1);//переход к следующему дню
            }

            return weekEvents;
        }
        /// <summary>
        /// вывод на консоль событий на текущую неделю
        /// </summary>
        public void PrintEventsForWeek()
        {
            var weekEvents = GetEventsForWeek();

            Console.WriteLine("-----------события на текущую неделю----------\n");
            
            foreach(KeyValuePair<DateOnly, List<string>> pair in weekEvents)
            {
                Console.WriteLine($"\nсобытия на {pair.Key:D}:");
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
