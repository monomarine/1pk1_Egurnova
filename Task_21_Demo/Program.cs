namespace Task_21_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime nowDate = DateTime.Now;
            DateTime date = new DateTime(2025,12,31,23,59,59);

            /*Console.WriteLine(nowDate.Year);
            Console.WriteLine(nowDate.Month);
            Console.WriteLine(nowDate.Day);
            Console.WriteLine(nowDate.Hour);
            Console.WriteLine(nowDate.Minute);
            Console.WriteLine(nowDate.Second);
            Console.WriteLine(nowDate.Microsecond);

            var nowDateAfter1000 = nowDate.AddDays(-1000);
            Console.WriteLine(nowDateAfter1000);*/


            /* TimeSpan duration = date - nowDate;

             Console.WriteLine(duration);
             Console.WriteLine($"до нового года {duration.Days} дней и {duration.Hours} часов");
             Console.WriteLine($"до нового года {duration.TotalHours:F2} всего часов");
             Console.WriteLine($"до нового года {duration.TotalMinutes:F2} всего минут");*/

            /* DateOnly dateOnly = new DateOnly(2000,10,15);
             TimeOnly timeOnly = new TimeOnly(12,50,40,545,564);
             Console.WriteLine(dateOnly);
             Console.WriteLine(timeOnly);*/

            /*DateOnly nowDateOnly = DateOnly.FromDateTime(nowDate);
            TimeOnly nowTimeOnly = TimeOnly.FromDateTime(nowDate);

            Console.WriteLine(nowDateOnly +"\n"+ nowTimeOnly);*/

            DateTimeOffset dateTimeOffset = new DateTimeOffset
                (
                    new DateTime(2025, 03, 29, 8, 00, 00), 
                    new TimeSpan(5,0,0)
                );
            DateTimeOffset dateTimeOffset7 = new DateTimeOffset
                (
                    new DateTime(2025,03,29, 10, 0, 0), 
                    new TimeSpan(7, 0, 0)
                );
            
           /* Console.WriteLine(dateTimeOffset7);
            Console.WriteLine(dateTimeOffset.Offset);
            DateTime noww = DateTime.UtcNow;

            Console.WriteLine(dateTimeOffset);
            Console.WriteLine(noww);*/

            TimeSpan duration = dateTimeOffset7 - dateTimeOffset;
            Console.WriteLine(duration);
        }
    }
}
