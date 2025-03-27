namespace Task_21_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 Дан список чисел. Создать новый список, содержащий только чётные числа из исходного списка, умноженные на 10.
            
            Random random = new Random();
            List<int> numbers = new List<int>(); //исходный список
            for (int i = 0; i < 20; i++)
                numbers.Add(random.Next(10, 100));

            foreach (int i in numbers)
                Console.Write(i + "\t");
            Console.WriteLine();

            List<int> numbers2 = new List<int>(); //список для четных значений
            //копирование нужных значений из исходного списка в новый
            foreach (int i in numbers)
            { 
                if(i % 2 == 0) numbers2.Add(i * 10);
            }

            foreach (int i in numbers2)
                Console.Write(i + "\t");
        }
    }
}
