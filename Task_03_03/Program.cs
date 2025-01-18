namespace Task_03_03
{
    internal class Program
    {
        /*Дано целое число N (> 0), являющееся некоторой степенью числа 2: 
         * N = 2^K. Найти целое число K — показатель этой степени.
            Пример
            Входные данные
            1024
            Выходные
            10
         */
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("введите число N - для проверки на степень числа 2");
                int number = int.Parse(Console.ReadLine());

                int power = 1; //начальное значение степени
                int osn = 2; //основание которое будем в цикле умножать на само себя неопределенное количество раз
                while (osn != number && osn < number)
                {
                    osn *= 2;
                    power++;
                }

                //проверка на корректность полученного значения
                var temp = Math.Pow(2, power);
                if (temp == number)
                    Console.WriteLine($"число {number} является степенью {power} числа 2");
                else
                    Console.WriteLine("число не является степенью числа 2");

            }
        }
    }
}
