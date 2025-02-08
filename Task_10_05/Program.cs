namespace Task_10_05
{
    internal class Program
    {
        /*Пользователь вводит целое неотрицательное число N, 
         * программа с помощью процедурных матода должна 
         * рассчитать и вывести площадь окружности с радиусом N (), 
         * объем(V = 4/3 π r^3) и площадь (4 π R 2) сфер с радиусом N. 
         * 
         * Осуществите бесконечный цикл для консольного 
         * ввода числа и вызова метода 
         * с выводом информации по выходному параметру
*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус:");
            int r = Convert.ToInt32(Console.ReadLine());

            PrintSphereCircleData(r);

        }

        static void PrintSphereCircleData(int r)
        {
            double sphereVolume = 4/3.0 * Math.PI * Math.Pow(r, 3);
            double sphereArea = 4 * Math.PI * Math.Pow(r, 2);
            double circleArea = Math.PI * r * r;

            Console.WriteLine($"Объём сферы: {sphereVolume}.");
            Console.WriteLine($"Площадь сферы: {sphereArea}.");
            Console.WriteLine($"Площадб окружности: {circleArea}.");
        }
    }
}
