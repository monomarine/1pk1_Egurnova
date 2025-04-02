namespace Task_24_01
{
    internal class Program
    {
        /*Задача: Создайте текстовый файл hello.txt в текущей директории приложения 
         * и запишите в него строку "Hello, World!" с использованием класса File.
            */
        static void Main(string[] args)
        {
            string fileName = "hello.txt";

            var fs =  File.Create(fileName);
            fs.Dispose();

            File.WriteAllText(fileName, "Hello, World!");
        }
    }
}
