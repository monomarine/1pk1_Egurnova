namespace Task_20_03
{
    internal class Program
    {
        /*
         Создайте программу для управления статусом заказа в интернет-магазине. Используйте перечисление OrderStatus со значениями:
            New (новый)
            Processing (в обработке)
            Shipped (отправлен)
            Delivered (доставлен)
            Cancelled (отменён)
            Напишите метод, который меняет статус заказа.
            Если заказ уже доставлен или отменён, запретите изменение статуса.
            Выводите сообщение при каждом изменении статуса (например, "Заказ переведён в статус: Отправлен").
            */
        static void Main(string[] args)
        {
            Order order = new Order();
            Console.WriteLine(order.Status);

            order.ChangeStatus();
            order.ChangeStatus();

            order.CancelOrder();
            order.ChangeStatus();
        }
    }
}
