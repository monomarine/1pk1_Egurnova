namespace Task_04_11
{
    internal class Program
    {
        /*Заполнить один массив случайными числами, 
         * другой - введенными с клавиатуры числами, 
         * в ячейки третьего записать суммы соответствующих ячеек первых двух. 
         * Вывести содержимое массивов на экран. 
         * 
         * Количество элементов в массивах задается пользователем и одинаково для всех массивов. */
        #pragma warning disable //для отключения предупреждений (зеленых подчеркиваний)
        static void Main(string[] args)
        {
            Console.WriteLine("задайте количество элементов в массиве");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("количество элементов не мб меньше или равно нуля. введите повторно");
                n = int.Parse(Console.ReadLine());
            }

            int[] array1 = new int[n];
            int[] array2 = new int[n];
            int[] array3 = new int[n];

            //1 массив - заполняется рандомом
            Random random = new Random();
            for(int i = 0; i < n; i++)
            {
                array1[i] = random.Next(100,1000);
            }
            // 2 массив - заполняется с консоли пользователем
            Console.WriteLine("теперь нужно ввести {0} целых чисел", n);
            int ind = 0;  
            while (ind != n) 
            {
                array2[ind] = int.Parse(Console.ReadLine()) ;
                ind++;
            }
            // 3 массив - является суммой двух предыдущих
            for(int i = 0; i< n; i++)
            {
                array3[i] = array1[i] + array2[i];
            }

            Console.Clear(); //очистка консоли перед выводом

            //вывод всех трех массивов в одном цикле, тк размеры одинаковы
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{array1[i]} + {array2[i]} = {array3[i]}");
            }
                
        }
    }
}
