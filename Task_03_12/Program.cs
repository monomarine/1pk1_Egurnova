namespace Task_03_12
{
    internal class Program
    {
        /*пользователь в бесконечном цикле вводит числа
         подсчитать сумму и произведению введенных чисел
        цикл останавливается при вводе 0*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа");
            int summ = 0;
            int multy = 1;
            while(true) 
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine($"Сумма всех чисел: {summ}\n " +
                        $"Произвнедение всех чисел: {multy}");
                    break;
                }
                
                summ += num;
                multy *= num;
            }
        }
    }
}
