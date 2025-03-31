namespace Task_23_03
{
    internal class Program
    {
        /**в произвольном каталоге удалите все вложенные каталоги с игнорированием наличия содержимого
*/
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            DirectoryInfo rootDirectory = new DirectoryInfo(path);
            if (rootDirectory.Exists)
            {
                List<DirectoryInfo> directories = rootDirectory.GetDirectories().ToList();
                foreach (DirectoryInfo d in directories)
                {
                    d.Delete(true);
                }


            }
        }
    }
}
