namespace Task_24_03
{
    internal class Program
    {
        /*Скопируйте файл source.txt в backup.txt 
         * в подкаталог Backup (создайте его, если нет). 
         * Используйте File.Copy().
        */
        static void Main(string[] args)
        {
            string backupPath = "Backup";
            string sourceFile = "source.txt";
            string backupFile = "backup.txt";

            File.Create(sourceFile).Dispose();
            File.WriteAllText(sourceFile, "1111\n2222\n3333");

            if(!Directory.Exists(backupPath) ) 
                Directory.CreateDirectory(backupPath);

            string temPath = Path.Combine(backupPath, backupFile);
            Console.WriteLine(temPath);
            
            File.Copy(sourceFile, temPath, true);


        }
    }
}
