namespace Task_05_01
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается число n, 
         * генерируется квадратный массив целых числе [n*n]. 
         * Заполнение случайными числами в диапазоне 
         * от 10 до 99 включительно. 
         * После вывода на консоль сгенерированного массива 
         * 
         * у пользователя запрашиваются номера строк для 
         * замены местами. После чего без очищения консоли 
         * выводится обновленный массив, где строки, 
         * поменявшиеся места выделены красным фоновым цветом 
         * (console.background) 
*/
        static void Main(string[] args)
        {
#pragma warning disable
            Console.WriteLine("введите n - размер квадратного массива");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("число д.б. больше нуля и целым");
                n = int.Parse(Console.ReadLine());
            }

            int[,] numbers = new int[n,n];
            Random random = new Random();

            for(int i =0; i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(10, 100);
                    Console.Write(numbers[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nвыберите строки, чтобы поменять местами");
            int ind1 = int.Parse(Console.ReadLine()) - 1 ;   
            int ind2 = int.Parse(Console.ReadLine()) - 1;

            int temp = 0;
            for(int j = 0; j < numbers.GetLength(1); j++)
            {
                temp = numbers[ind1, j];
                numbers[ind1, j] = numbers[ind2, j];
                numbers[ind2, j] = temp;
            }
            //вывод обновленного массива с цевтовой подсветкой
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (i == ind1 || i == ind2)
                    Console.BackgroundColor = ConsoleColor.Red;
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j]+" ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }
    }
}
