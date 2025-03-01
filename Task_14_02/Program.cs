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
            Car car = new Car("56 JFH 45", 10);

            car.Drive(10);

            Console.WriteLine(Logger.Read());
        }
    }
}
