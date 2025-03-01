namespace Task10_02
{
    internal class Program
    {
        /*Вычислить сумму: 1!+2!+3!+…+n!, 
         * используя функцию вычисления факториала числа k. 
            Использовать метод для нахождения факториала (факториал находить через цикл). 
            */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("введите число n - до которого требуется вычислить сумму всех факториалов");
                int n = Convert.ToInt32(Console.ReadLine());

                ulong fact = 0;
                while (n > 0)
                {
                    fact += Factorial(n);
                    n--;
                }


                Console.WriteLine($"сумма факториалов до  n = {fact}");
                Console.WriteLine($"максимальное ulong знач = {ulong.MaxValue}");
                Console.WriteLine($"максимальное ulong знач = {ulong.MinValue}");

                Console.ReadKey();
            }
        }
        /// <summary>
        /// факториал числа
        /// </summary>
        /// <param name="k">число факториала</param>
        /// <returns>факториал</returns>
        public static ulong Factorial(int k)
        {
            ulong result = 1;
            while(k > 0)
            {
                result *= (ulong)k;
                k--;
            }
            return result;
        }
    }
}
