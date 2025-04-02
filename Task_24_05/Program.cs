namespace Task_24_05
{
    internal class Program
    {
        /*Объедините содержимое всех .txt файлов 
         * из папки Parts в один файл combined.txt.
        */
        static void Main(string[] args)
        {
            string path = "Parts";
            File.Create(Path.Combine(path, "combined.txt")).Dispose();

            for( int i = 0; i< 10; i++)
            {
                string tempPath = Path.Combine(path, $"{i}file.txt");
                File.Create(tempPath).Dispose();
                File.WriteAllText(tempPath, new string(i, i+1))
            }

            DirectoryInfo dir = new DirectoryInfo(path);
            List<FileInfo> files = dir.GetFiles().ToList();

            foreach (FileInfo file in files) 
            {
                if(file.Extension == "txt")
                { }
            }
        }
    }
}
