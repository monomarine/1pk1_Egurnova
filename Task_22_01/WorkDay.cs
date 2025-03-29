using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_01
{

    /*Создать класс WorkDay, который хранит дату (DateOnly) 
     * и времена начала/окончания работы (TimeOnly).
    Методы:
    GetDuration() - возвращает TimeSpan продолжительности рабочего дня
    AddBreak(TimeSpan) - добавляет перерыв к рабочему дню*/
    
    internal class WorkDay
    {
        private DateOnly date;
        private TimeOnly startTime, endTime;
        private TimeSpan breakDuration;

        public DateOnly Date => date;
        public TimeOnly StartTime => startTime;
        public TimeOnly EndTime => endTime;

        public WorkDay(DateOnly date, TimeOnly startTime, TimeOnly endTime)
        {
            this.date=date;
            this.startTime=startTime;
            if (endTime > startTime)
                this.endTime=endTime;
            else
            {
                Console.WriteLine("конец рабочего дня раньше начала");
                endTime = new TimeOnly(18, 0, 0);
            }
        }

        public double GetDuration()
        {
            TimeSpan result = endTime - startTime - breakDuration;
            return result.TotalHours;
        }

        public void AddBreak(TimeSpan breakDuration)
        {
            this.breakDuration = breakDuration;
        }
    }
}
