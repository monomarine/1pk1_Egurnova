namespace Task_24_04
{
    internal class Program
    {
        static string logFile = "log.txt";
        /*Напишите метод, который дописывает в файл log.txt 
         * текущую дату и переданное сообщение. 
         * Используйте StreamWriter с append: true.
        */
        static void Main(string[] args)
        {
            WriteToLog(logFile);
        }
        static void WriteToLog(string message)
        {
            using (StreamWriter writer = new StreamWriter(logFile, append: true))
            {
                writer.WriteLine($"{DateTime.Now}: \"{message}\"");
            }
        }
    }
}
