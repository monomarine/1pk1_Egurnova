namespace Task_04_01
{
    internal class Program
    {
        /*Дан массив из 30 целых числе, заполненных рандомно 
         * в диапазоне от 10 до 99 вкл. 
         * Вывести количество пар соседних 
         * элементов массива, кратных пяти.
        */
        static void Main(string[] args)
        {
            int[] numbers = new int[30];
            Random random = new Random();   

            //заполнение массива и вывод
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(0,21);
                Console.Write(numbers[index] + " ");
            }

            //поиск пар начиная со 2 элемента
            int countOfPairs = 0;
            for (int i = 1; i< numbers.Length; i++)
            {
                if (numbers[i] % 5 == 0 && numbers[i-1] % 5 == 0)
                { 
                    //TODO - доделать вывод цветом
                    countOfPairs++;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(numbers[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }



            Console.WriteLine($"\n\nколичество пар чисел кратных пяти - {countOfPairs}");
        }
    }
}
