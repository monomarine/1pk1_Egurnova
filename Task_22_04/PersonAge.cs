using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_04
{
    /*
        Создать класс PersonAge, который вычисляет возраст на основе DateOnly (даты рождения).
       Методы:
       GetAgeAtDate(DateOnly) - возраст на конкретную дату
       GetNextBirthday() - сколько дней до следующего ДР
       IsLeapYearBirth() - родился ли в високосный год
       */
    internal class PersonAge
    {
        private DateOnly birthday;
        public DateOnly Birthday => birthday;

        public PersonAge(DateOnly date) 
        {
            birthday = date;
        }

        public int GetAgeAtDate(DateOnly date) 
        {
            if (date.Month >= birthday.Month && date.Day >= birthday.Day)
            {
                return DateTime.Now.Year - birthday.Year;
            }
            else return DateTime.Now.Year - birthday.Year - 1;
        }

        public int GetNextBirthdayDays()
        {
            var today = DateTime.Now; //получаем текущую дату

            //определяем следующий день рождения путем установки года на текущий (месяц и день оставляем прежними)
            DateOnly nextBirthday =  new DateOnly(today.Year, birthday.Month, birthday.Day); 
            
            //если на этот год день рождения прошел (текущий месяц и день больше) то следующий др переносится на следующий год
            if (today.Month >= birthday.Month && today.Day >= birthday.Day)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            Console.WriteLine("следующий день рождения " + nextBirthday);
            
            //DateOnly дата рождения преобразовывается в DateTime (добавляется время)
            //после чего вычисляется разница и возвращается количество дней
            return (nextBirthday.ToDateTime(new TimeOnly(0,0,0)) - today).Days + 1;

        }
    }
}
