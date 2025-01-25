namespace Task_05_10
{
    internal class Program
    {
        //создать массив - содержащую таблицу пифагора
        //при выводе прдусмотреть легенду
        static void Main(string[] args)
        {
            int[,] pifagor = new int[8, 8];
            for (int t=2; t<10; t++)
            {
                Console.Write("\t" + t);
            }
            Console.WriteLine("\n_______________________________________________________________________________________");
            for (int i = 0; i < pifagor.GetLength(0); i++)
            {
                Console.Write(i+2 + " |");
                for (int j = 0; j < pifagor.GetLength(1); j++) 
                {
                    pifagor[i, j]=(i+2)*(j+2);
                    Console.Write("\t" + pifagor[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
