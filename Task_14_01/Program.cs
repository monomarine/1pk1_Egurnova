namespace Task_14_01
{
    internal class Program
    {
        /* Создайте произвольный класс, который будет иметь 
         * статическую переменную count, чтобы отслеживать 
         * количество экземпляров класса. Каждый раз, 
         * когда вы создаете новый экземпляр класса, 
         * увеличивайте count на 1. Создайте метод GetCount(), 
         * возвращающий текущее значение count.
        */
        static void Main(string[] args)
        {
            Item i1 = new Item();
            Item i2 = new Item("ромашка");
            Item i3 = new Item(120, "sunflower");
            Item i = new Item();
            Item.GetItemsCount();

            i3.Dispose();
            Item.GetItemsCount();
        }
    }
}
