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

                long fact = 0;
                while (n > 0)
                {
                    fact += Factorial(n);
                    n--;
                }


                Console.WriteLine($"сумма факториалов до n = {fact}");
                Console.WriteLine($"максимальное long знач = {long.MaxValue}");

                Console.ReadKey();
            }
        }
        /// <summary>
        /// факториал числа
        /// </summary>
        /// <param name="k">число факториала</param>
        /// <returns>факториал</returns>
        public static long Factorial(int k)
        {
            long result = 1;
            while(k > 0)
            {
                result *= k;
                k--;
            }
            return result;
        }
    }
}
