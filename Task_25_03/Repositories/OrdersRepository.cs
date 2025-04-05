using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_25_03.Repositories
{
    internal static class OrdersRepository
    {
        static string ordersSaveFile = "orders.json";
        static List<Order> orders;

        static OrdersRepository()
        {
            LoadData();
        }

        private static void LoadData()
        {
            if (!File.Exists(ordersSaveFile))
                orders = new();
            else
                orders =  JsonSerializer.Deserialize<List<Order>>(File.ReadAllText(ordersSaveFile));
        }

        public static void SaveData()
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string jsonString = JsonSerializer.Serialize(orders, options);
            File.WriteAllText(ordersSaveFile, jsonString);
        }

        public static void CreateNewOrder()
        {
            Console.Clear();
            Console.WriteLine("введите имя клиента");
            string customerName = Console.ReadLine();

            if (customerName == "")
            {
                Console.WriteLine("имя клиента не может быть пустым");
                return;
            }
            Console.WriteLine(orders.Count());

            Order order = new Order()
            {
                Id = orders.Count == 0 ? 1 : orders.Last().Id + 1,//номер заказа увеличивается на единицу по сравнению с последним в списке
                Date = DateTime.Now,
                Products = new List<Product>(),
                Customer = customerName
            };


            //--------внесение продуктов в заказ (можно вынести в отдельный метод)

            Console.WriteLine("введите название продуктов для добавления в заказ:");
            string productName;
            while ((productName = Console.ReadLine())!="")
            {
                if (ProductRepository.GetProductByName(productName, out Product prod))
                {
                    order.Products.Add(prod);
                }
            }
            //-----------

            orders.Add(order);


        }

        public static void ShowAllOrders()
        {
            Console.WriteLine("\n--------------------------------------\n" +
                $"заказы в системе на {DateTime.Now:g}\n" +
                $"--------------------------------------\n");

            int n = 1;
            if (orders != null)
            {
                foreach (Order order in orders)
                {
                    Console.WriteLine($"{n++}: номер заказа: {order.Id:D5}\t{order.Customer}\n");
                    int j = 1;
                    foreach (Product prod in order.Products)
                    {
                        Console.WriteLine($"{j++}: {prod.Name}");
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("список заказов пуст");
        }

        public static decimal GetTotalRevenue()
        {
            return 0;   
        }
        public static decimal GetRevenueForDate() 
        {
            return 0;
        }
    }
}
