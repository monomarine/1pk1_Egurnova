namespace Task_23_02
{
    internal class Program
    {
        /*осуществите полный анализ каталогов в произвольной папке:
        название
        полный путь
        дата создания
        корневой каталог
        */
        static void Main(string[] args)
        {
            Console.WriteLine("введите путь к каталогу");
            string path = Console.ReadLine();

            DirectoryInfo directory = new DirectoryInfo(path);
            if (directory.Exists)
            { 
                List<DirectoryInfo> list = directory.GetDirectories().ToList();
                Console.WriteLine($"информация о каталагох в {directory.Name}");
                foreach (DirectoryInfo subDirectory in list)
                {
                    Console.WriteLine($"{subDirectory.Name} - {subDirectory.FullName}\n" +
                        $"\t дата создания: {subDirectory.CreationTime}\n" +
                        $"\t корневой каталог: {subDirectory.Parent}\n" +
                        $"\t последнее обращение: {subDirectory.LastAccessTime}");
                }
            }
        }
    }
}
