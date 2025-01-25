namespace Task_05_02
{
    internal class Program
    {
        /*
         У пользователя в консоли запрашивается числа n и m, 
        генерируется прямоугольный массив целых числе [n*m]. 
        Заполнение случайными числами в диапазоне от 10 до 99 включительно. 
        
        Осуществите транспонирование матрицы (перестановку строк и столбцов). 
        Без очищения консоли выведите новую матрицу. 	

         */
        static void Main(string[] args)
        {
#pragma warning disable
            Console.WriteLine("введите n - количество строк");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("введите m - количество столбцов");
            int m = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(10, 100);
                    Console.Write(numbers[i, j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nТранспонированная матрица:\n");
            int[,] transponedNumbers = new int[m, n];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    transponedNumbers[j, i] = numbers[i, j];
                }
            }

            //вывод транспонированной матрицы

            for (int i = 0; i < transponedNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < transponedNumbers.GetLength(1); j++)
                {
                    Console.Write(transponedNumbers[i, j] +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
