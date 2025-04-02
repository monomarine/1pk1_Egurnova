using System.Runtime.InteropServices;

namespace Task_24_02
{
    internal class Program
    {
        /*Используя FileInfo, прочитайте содержимое файла data.txt (предварительно созданного) 
         * и выведите его построчно в консоль.
        */
        static void Main(string[] args)
        {
            string fileName = "data.txt";
            string text = "hello\n2222\n33333\n44444";

            File.Create(fileName).Dispose();
            File.WriteAllText(fileName, text);

            FileInfo fileInfo = new FileInfo(fileName);
            using (StreamReader reader = fileInfo.OpenText())
            {
                string line;
                while((line = reader.ReadLine() )!= null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
