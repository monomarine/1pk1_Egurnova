using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    /*
      Напишите метод, который меняет статус заказа.
            Если заказ уже доставлен или отменён, запретите изменение статуса.
            Выводите сообщение при каждом изменении статуса (например, "Заказ переведён в статус: Отправлен")*/
    internal class Order
    {
        public OrderStatus Status { get; set; }

        public Order()
        {
            Status = OrderStatus.New;
        }
        /// <summary>
        /// статус переходит к следующему по цепочке только в случае если
        /// заказ не отменен или не доставлен
        /// </summary>
        public void ChangeStatus()
        {
            if (Status != OrderStatus.Cancelled && Status != OrderStatus.Delivered)
            {
                Status++;
                Console.WriteLine($"статус заказа изменен на {Status}");
            }
            else
            {
                Console.WriteLine("невозможно изменить статус заказа, тк он отменен или доставлен");
            }
        }

        public void CancelOrder()
        {
            if (Status != OrderStatus.Cancelled && Status != OrderStatus.Delivered)
            {
                Status = OrderStatus.Cancelled;
                Console.WriteLine("Заказ отменен");
            }
            else { Console.WriteLine("невозможно изменить статус заказа, тк он отменен или доставлен"); }
        }
    }
}
