namespace Task_03_01
{
    internal class Program
    {
        /*Выведите классическую таблицу умножения 
         * используя вложенные циклы
         */
        static void Main(string[] args)
        {
            for( int i = 2; i < 11;  i++ ) //внешний цикл
            {
                Console.WriteLine($"умножение на {i}");

                for (int j = 2; j< 11; j++) //внутренний цикл
                {
                    Console.WriteLine($"{i} * {j} = {i*j}"); //интеполированный вывод
                }
                Console.WriteLine();
            }
        }
    }
}
