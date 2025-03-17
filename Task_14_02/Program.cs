namespace Task_14_02
{
    internal class Program
    {
        /* Напишите класс Logger, который имеет статический конструктор 
         * для инициализации статического поля, 
         * отвечающего за название файла журнала. 
         * Логирование будет осуществляться через статический метод.
        */
        static void Main(string[] args)
        {
            Car car = new Car("56 JFH 45", 0);

            car.Drive(20);

            Console.WriteLine("вывод текущего журнала");
            Console.WriteLine(Logger.Read());

            Console.WriteLine("\nвывод критического журнала");
            Console.WriteLine(Logger.ReadCriticalLog());
        }
    }
}
