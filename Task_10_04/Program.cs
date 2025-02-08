namespace Task_10_04
{
    internal class Program
    {
        //Реализуйте метод GetMaxInArray поиска наибольшего числа из массива чисел.

        static void Main(string[] args)
        {
            int[] data = GetGeneratedArray(10);
            PrintArray(data, '*');

            int maxValue = GetMaxValueInArray(data);

            Console.WriteLine("\nмаксимальный элемент в массиве - " + maxValue);
        }
        /// <summary>
        /// ищет максимальное значение в массиве
        /// </summary>
        /// <param name="array">массив</param>
        /// <returns>максимальное значение</returns>
        public static int GetMaxValueInArray(int[] array)
        {
            int max = array[0];

            for(int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            return max;
        }
        /// <summary>
        /// генерация одномерного целочисленного массива
        /// </summary>
        /// <param name="length">количество элементов</param>
        /// <returns></returns>
        public static int[] GetGeneratedArray(int length)
        {
            Random random = new Random();   
            int[] array = new int[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = random.Next(10,100);
            }
            return array;
        }
        /// <summary>
        /// вывод на консоль массива 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="separator">разделитель элементов</param>
        public static void PrintArray(int[] array, char separator)
        {
            foreach(int c in array)
                Console.Write(c+separator.ToString());
        }
    }
}
