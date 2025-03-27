namespace Task_21_04
{
    internal class Program
    {
        /*Дан SortedSet<int>. Написать метод, который возвращает подмножество элементов, значения которых лежат в
            заданном диапазоне [start, end].*/
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 23,57,7,657,43,45,6,7,78,34,34,5,7,66,6,6,56,5,5,344,53 };
            foreach (int i in set)
                Console.Write(i + " ");

            Console.WriteLine();
            var subSet = GetSubSet(ref set, 23, 57);
            foreach (int i in subSet)
                Console.Write(i + " ");
        }

        static SortedSet<int> GetSubSet(ref SortedSet<int> set, int start, int end)
        {
            return set.GetViewBetween(start, end);
        }
    }
}
