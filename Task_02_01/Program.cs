namespace Task_01
{
    internal class Program
    {
       /*Найти значение выражения 
        * при a = 0, b = 6, c = 2
        * 
        */
        static void Main(string[] args)
        {
            double a = Math.PI;
            double b = 6;
            double c = 2;

            double part1 = 5 * Math.Atan(a);
            double part2 = 0.25 * Math.Cos(a);
            double part3 = a + 3 * Math.Abs(a - b) + a * a;
            double part4 = Math.Abs(a - b) * c + Math.Pow(a, 2);

            double result = part1 - part2 * (part3 / part4);
            Console.WriteLine(Math.Round(result,2));

            Console.WriteLine(Math.E);
           
        } 
    }
}


