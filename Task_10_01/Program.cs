﻿namespace Task_10_01
{
    internal class Program
    {
        /*Создать Метод GetArea принимающий значение 
         * боковой стороны конуса и радиуса основания 
         * и возвращающий площадь полной поверхности конуса 
         * и площадь боковой поверхности конуса. 
                (Pбок = pi * r * l, Pобщ = pi * r * l + pi * r * r)
        */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("введите боковую сторону конуса >>");
                double sideLeght = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("введите радиус основания конуса >>");
                double radius = Convert.ToDouble(Console.ReadLine());

                double[] res = GetArea(sideLeght, radius);

                Console.WriteLine($"полная площадь конуса: {res[0]}\n" +
                    $"площадь боковой площади конуса: {res[1]}");

                Console.ReadKey();
            }
        }
        /// <summary>
        /// возвращает абщую и боковую площади конуса
        /// </summary>
        /// <param name="l">боковая сторона конуса</param>
        /// <param name="r">радиус основания</param>
        /// <returns>массив: 1 значение - полная площадь
        ///  2 значение - площадь боковой стороны</returns>
        public static double[] GetArea(double l, double r)
        {
            double[] result = new double[2];
            double sideArea = Math.PI * l * r;
            double fullArea = sideArea + Math.PI * r * r;
            result[0] = fullArea;
            result[1] = sideArea;

            return result;
        }
    }
}
