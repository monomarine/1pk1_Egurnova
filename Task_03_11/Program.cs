namespace Task_03_11
{
    internal class Program
    {
        //вывести таблицу квадратов в диапазоне, задаваемым пользователем
        static void Main(string[] args)
        {
            Console.WriteLine("введите диапазона значений для вывода квадратов (a, b)");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"квадраты числе в диапазоне от {a} до {b}");
            for (int i = a; i <= b; i++) 
            {
                Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
            }
        }
    }
}
