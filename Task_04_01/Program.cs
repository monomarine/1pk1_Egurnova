namespace Task_04_01
{
    internal class Program
    {
        /*Дан массив из 30 целых числе, заполненных рандомно 
         * в диапазоне от 10 до 99 вкл. 
         * Вывести количество пар соседних 
         * элементов массива, кратных пяти.
         * 
         * - дополнительно вывести массив повторно отметив цветов эти числа
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

            bool[] isPair = new bool[30]; //массив флагов для обозначения найденных пар

            //поиск пар начиная со 2 элемента
            int countOfPairs = 0;
            for (int i = 1; i< numbers.Length; i++)
            {
                if (numbers[i] % 5 == 0 && numbers[i-1] % 5 == 0)
                { 
                    countOfPairs++;
                    isPair[i] = true;
                    isPair[i-1] = true;
              
                }
            }

            //вывод с выделением цветом
            for (int i = 0; i < numbers.Length; i++)
            {
                if (isPair[i])//если есть отметка в массиве isPair что этот элемент является парным, то выделяем цветом
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(numbers[i]+ " ");
                    Console.ForegroundColor= ConsoleColor.White;
                }
                else //в противном случае при выводе фон не меняется
                {
                    Console.Write(numbers[i]+ " ");
                }
            }



            Console.WriteLine($"\n\nколичество пар чисел кратных пяти - {countOfPairs}");
        }
    }
}
