using System.Diagnostics;

namespace Task_24_05
{
#pragma warning disable
    internal class Program
    {
        /*Объедините содержимое всех .txt файлов 
         * из папки Parts в один файл combined.txt.
        */
        static void Main(string[] args)
        {
            // Получаем текущую директорию
            string currentDirectory = Directory.GetCurrentDirectory();
            string partsDirectory = Path.Combine(currentDirectory, "Parts");
            string outputFile = Path.Combine(currentDirectory, "combined.txt");

            // Проверяем существование подпапки Parts
            if (!Directory.Exists(partsDirectory))
            {
                Console.WriteLine("Папка 'Parts' не найдена в текущей директории.");
                return;
            }

            // Получаем все текстовые файлы в подпапке Parts
            List<string> textFiles = Directory.GetFiles(partsDirectory, "*.txt").ToList();

            if (textFiles.Count == 0)
            {
                Console.WriteLine("В папке 'Parts' не найдено текстовых файлов.");
                return;
            }

            // Объединяем содержимое файлов
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                foreach (string file in textFiles)
                {
                    string content = File.ReadAllText(file);
                    writer.WriteLine(content);
                    writer.WriteLine(); // Добавляем пустую строку между файлами
                }
            }

            // Удаляем исходные файлы
            foreach (string file in textFiles)
            {
                File.Delete(file);
            }

            Console.WriteLine($"Объединение завершено. Результат сохранен в {outputFile}");
            Console.WriteLine($"Удалено {textFiles.Count} исходных файлов.");
            Process.Start("explorer.exe", currentDirectory);
        }
    }
}
