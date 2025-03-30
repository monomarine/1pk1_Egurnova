namespace Task_22_04
{
    internal class Program
    {
        /*
         Создать класс PersonAge, который вычисляет возраст на основе DateOnly (даты рождения).
        Методы:
        GetAgeAtDate(DateOnly) - возраст на конкретную дату
        GetNextBirthday() - сколько дней до следующего ДР
        IsLeapYearBirth() - родился ли в високосный год
        */
        static void Main(string[] args)
        {
            PersonAge pa1 = new PersonAge(new DateOnly(2010, 04, 1));
            Console.WriteLine(pa1.GetAgeAtDate(DateOnly.FromDateTime(DateTime.Now)));

            int days = pa1.GetNextBirthdayDays();

            Console.WriteLine(days);
        }

    }
}
