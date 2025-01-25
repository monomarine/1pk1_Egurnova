namespace Task_04_03
{
    internal class Program
    {
        /*В массиве-табеле записаны оценки ученика по предмету. 
         * Размер массива = 10. Заполнение рандомом в диапазоне от 2, до 5 вкл. 
         * Рассчитать и вывести средний балл ученика, оценку, 
         * которая чаще всего встречается в табеле, количество двоек.
        */

        static void Main(string[] args)
        {
            int[] marks = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < marks.Length; i++)
                marks[i] = rnd.Next(2, 6);

            Console.WriteLine(String.Join(", ", marks));

            //Вычисление среднего балла
            float summ = 0;
            foreach (int i in marks)
                summ += i;
            Console.WriteLine("Ср. балл: " + Math.Round(summ / marks.Length, 2));

            //нахождение наиболее часто встречающихся оценок
            int[] counts = new int[6];
            for (int i = 0; i < marks.Length; i++)
                counts[marks[i]]++;
            int max_count_index = 0;
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > counts[max_count_index])
                    max_count_index = i;
            }
            Console.WriteLine("Наиболее частая оценка: " + max_count_index);

            Console.WriteLine("Кол-во двоек: " + counts[2]);
        }
    }
}
