namespace Task_23_04
{
    internal class Program
    {/*осуществите перемещение одного каталога в новое место, с одновременным созданием пути для перемещения
*/
        static void Main(string[] args)
        {
            Console.WriteLine("введите путь к каталогу который требуется переместить");
            string pathFrom = Console.ReadLine();
            Console.WriteLine("введите не существующий каталог куда его требуется перенести");
            string pathTo = Console.ReadLine();

            DirectoryInfo dirFrom = new DirectoryInfo(pathFrom);
            if (dirFrom.Exists) 
            { 
                if(!Directory.Exists(pathTo))
                {
                    //DirectoryInfo target = Directory.CreateDirectory(pathTo);
                  
                    
                    Directory.Move(pathFrom,pathTo);
                }
            }
        }
    }
}
