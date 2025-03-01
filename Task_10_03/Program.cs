namespace Task_10_03
{
    internal class Program
    {
        /* Реализуйте метод, который в качестве параметров 
         * принимает значения стороны и высоты и 
         * выводит сообщение о наибольшем параллелограмме 
         * по его площади. 
         */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("введите высоту 1 параллелограмма");
                double h1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("введите основение 1 параллелограмма");
                double a1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("введите высоту 2 параллелограмма");
                double h2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("введите основение 2 параллелограмма");
                double a2 = Convert.ToDouble(Console.ReadLine());

                double area1 = GetParallelogramArea(h1, a1);
                double area2 = GetParallelogramArea(h2, a2);

                string result = area1 >= area2 ? 
                    "первый параллелограмм больше второго или они равны" :
                    "первый параллелограмм меньше второго";
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
        /// <summary>
        /// возвращает площадь параллелограмма по высоте и основанию
        /// </summary>
        /// <param name="height">высота</param>
        /// <param name="osn">основание</param>
        /// <returns></returns>
        public static double GetParallelogramArea(double height, double osn)
        {
            return osn * height;
        }
    }
}
