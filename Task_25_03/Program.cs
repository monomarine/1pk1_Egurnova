using System.Diagnostics;
using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Task_25_03
{
    #pragma warning disable

    /*
     создайте класс Продукта (цена,стоимость) 
    класс Заказа(номер заказа, клиент, дата заказа, список товаров в заказе, метод для расчета стоимости всего заказа)

    сохраните в файл orders.json все заказы в системе
    восставновите заказы в системе из файла
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            string fileName = "orders.json";

            //заранее подготовленные продукты для добавления в заказ
            Product product1 = new Product
            {
                Name = "сырок",
                Price = 15.0m
            };
            Product product2 = new Product
            {
                Name = "яблоко",
                Price = 120.0m
            };
            Product product3 = new Product
            {
                Name = "колбаса",
                Price = 300.0m
            };


            //список заказов заполненный через список инициализаторов
            List<Order> orders = new List<Order>
            {
                new Order //первый заказ в списке
                {
                    Id = 1,
                    Customer = "Иванов ИИ",
                    Date = DateTime.Now,
                    Products = new List<Product> { product1, product2 } //имеет свой список продуктов
                },
                new Order //второй заказ в списке
                {
                    Id = 2,
                    Customer = "Сидоров СС",
                    Date = DateTime.Now,
                    Products = new List<Product> { product3, product3, product3 } //список продуктов отличается
                }
            };

            //создание объекта JsonSerializerOptions
            //для управления параметрами сериализации
            var options = new JsonSerializerOptions
            {
                WriteIndented = true, //включение переноса на новую строку
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping //включение поддержки кириллицы
            };

            //сериализация коллекции заказов
            string jsonString = JsonSerializer.Serialize<List<Order>>(orders, options);
            
            //запись сериализованных данных в файл
            File.WriteAllText(fileName, jsonString);

            //открытие проводника с папкой текущей директории (для удабства проверки)
            Process.Start("Explorer.exe", Directory.GetCurrentDirectory());


            //вывод стоимости заказов 
            Console.WriteLine("стоимость заказов:");
            foreach (var order in orders)
            {
                Console.WriteLine($"заказ клиента {order.Customer} - {order.GetTotalAmount():C}");
            }

        }
    }
}
