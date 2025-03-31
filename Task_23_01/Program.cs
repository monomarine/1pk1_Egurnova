using System.Diagnostics;

namespace Task_23_01
{
    internal class Program
    {
        /*пользователь вводит путь к существующему каталогу, 
         * строку с названием новой папки и число - определяющее количество 
         * создаваемых каталогов. в сущесвующем каталоги создаются 
         * папки с введенным названием и нужным количество. 
         * к концу имени каталога примисывается число - уникальный номер  каталога
        */
        static void Main(string[] args)
        {
            Console.WriteLine("введите путь к существующему каталогу, название для генерации папок и их количество");
            string path = Console.ReadLine();   
            string name = Console.ReadLine();
            int count = Convert.ToInt32(Console.ReadLine()); 
            
            if(Directory.Exists(path))
            {
                DirectoryInfo rootPath = new DirectoryInfo(path);
                for (int i = 1; i<= count; i++)
                {
                    rootPath.CreateSubdirectory(name + i);
                }
    
            }
            else
                Console.WriteLine($"каталога {path} не существует");
        }
    }
}
