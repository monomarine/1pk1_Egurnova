namespace Task_04_02
{
    internal class Program
    {
        /*Дан массив, заполненный случайными целыми числами, 
         * без нулей. Осуществить копирование отрицательных 
         * и положительных элементов в разные массивы*/
        static void Main(string[] args)
        {
#pragma warning disable

            Console.WriteLine("введите количество элементов массива");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int i = 0;
            int countOfNegative = 0; //счетчик отриц значений
            Random random = new Random();   

            //заполнение массива значениями по условию
            while(i != n)
            {
                int temp = random.Next(-99, 100);
                if (temp == 0)
                    continue;
                numbers[i] = temp;
                if (numbers[i] < 0) countOfNegative++;
                Console.Write(numbers[i]+" ");
                i++;
            }

            int[] negative = new int[countOfNegative];
            int[] positive = new int[n - countOfNegative];

            Array.Sort(numbers);  //сортировка по возрастанию

            Console.WriteLine("\nмассив с отрицательными значениями:");
            for (int index = 0; index < countOfNegative; index++)
            {
                negative[index] = numbers[index];
                Console.Write(negative[index]+ " ");
            }

            Console.WriteLine("\nмассив с положительными значениями:");
            for(int index = 0; index < positive.Length; index++ )
            {
                positive[index] = numbers[index + countOfNegative];
                Console.Write(positive[index]+ " ");
            }

        }
    }
}
