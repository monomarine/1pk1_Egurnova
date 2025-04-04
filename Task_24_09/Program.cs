namespace Task_24_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---предварительная подготовка - создание и запись текста в файл
            string filename = "source.txt";
            File.Create(filename).Dispose();
            string? content = Console.ReadLine();
            File.WriteAllText(filename, content);


            //считывание текста из файла
            string contentfromFile = File.ReadAllText(filename);
            //разбивка на слова
            string[] text = contentfromFile.Split();
            //вывод количества слов - слина полученного массива
            Console.WriteLine("количество слов в файле - " + text.Length);


            // дополнительно вывод информации по файлу
            FileInfo file = new FileInfo(filename);
            Console.WriteLine($"информация по файлу: \n" +
                $"дата создания  - {file.CreationTime}\n" +
                $"дата последнего доступа - {file.LastAccessTime}\n" +
                $"дата последней записи в файл - {file.LastWriteTime}");
        }
    }
}
