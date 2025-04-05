using System.Diagnostics;
using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Json;
using Task_25_03.Repositories;

namespace Task_25_03
{
    #pragma warning disable

    /*
     создайте класс Продукта (цена,стоимость) 
    класс Заказа(номер заказа, клиент, дата заказа, список товаров в заказе, метод для расчета стоимости всего заказа)

    сохраните в файл orders.json все заказы в системе
    восстановите заказы в системе из файла
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("ru-Ru");

            while (true)
            {
                
                Console.Clear();

                Console.WriteLine
                  ($"0 - выход из приложения\n" +
                   $"1 - оформление нового заказа\n" +
                   $"2 - просмотр всех заказов\n" +
                   $"3 - просмотр всех продуктов\n" +
                   $"4 - добавление продукта\n" +
                   $"5 - удаление продукта\n" +
                   $"6 - вывод общей выручки\n" +
                   $"7 - вывод выручки за день");

                Mode mode = (Mode)Convert.ToInt32( Console.ReadLine() );

                switch (mode)
                {
                    case Mode.Exit: //выход из приложения
                        ProductRepository.SaveData(); //сохранение списка продуктов
                        OrdersRepository.SaveData();  //сохранение списка заказов
                        return;

                    case Mode.CreateNewOrder://режим оформления нового заказа
                        OrdersRepository.CreateNewOrder();
                        break;

                    case Mode.ShowAllOrders: //просмотр всех заказов
                        OrdersRepository.ShowAllOrders();
                        break;

                    case Mode.ShowAllProducts: //просмотр всех продуктов
                        ProductRepository.ShowAllProducts();    
                        break;

                    case Mode.AddProduct: //добавление продукта
                        ProductRepository.AddProduct();
                        break;

                    case Mode.DeleteProduct: //удаление продукта
                        ProductRepository.DeleteProduct();
                        break;

                    case Mode.TotalRevenue: //вывод общей выручки
                        OrdersRepository.GetTotalRevenue();
                        break;
                    
                    case Mode.DayRevenue: //выручка за текущий день
                        OrdersRepository.GetRevenueForDate();
                        break;
                }
                Console.ReadKey();  
            }
            

            /*
            ////заранее подготовленные продукты для добавления в заказ
            //Product product1 = new Product
            //{
            //    Name = "сырок",
            //    Price = 0.5m
            //};
            //Product product2 = new Product
            //{
            //    Name = "яблоко",
            //    Price = 1m
            //};
            //Product product3 = new Product
            //{
            //    Name = "колбаса",
            //    Price = 2m
            //};


            //список заказов заполненный через список инициализаторов
            //List<Order> orders = new List<Order>
            //{
            //    new Order //первый заказ в списке
            //    {
            //        Id = 1,
            //        Customer = "Иванов ИИ",
            //        Date = DateTime.Now,
            //        Products = new List<Product> { product1, product2 } //имеет свой список продуктов
            //    },
            //    new Order //второй заказ в списке
            //    {
            //        Id = 2,
            //        Customer = "Сидоров СС",
            //        Date = DateTime.Now,
            //        Products = new List<Product> { product3, product3, product3 } //список продуктов отличается
            //    }
            //};

            //создание объекта JsonSerializerOptions
            //для управления параметрами сериализации
            //var options = new JsonSerializerOptions
            //{
            //    WriteIndented = true, //включение переноса на новую строку
            //    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping //включение поддержки кириллицы
            //};

            ////сериализация коллекции заказов
            //string jsonString = JsonSerializer.Serialize<List<Order>>(orders, options);

            ////запись сериализованных данных в файл
            //File.WriteAllText(fileName, jsonString);

            ////открытие проводника с папкой текущей директории (для удабства проверки)
            //Process.Start("Explorer.exe", Directory.GetCurrentDirectory());


            ////вывод стоимости заказов 
            //Console.WriteLine("стоимость заказов:");
            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"заказ клиента {order.Customer} - {order.GetTotalAmount():C}");
            //}*/

        }
    }
}
