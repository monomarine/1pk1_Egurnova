using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_25_03.Repositories
{
    /// <summary>
    /// класс репозиятория продуктов - инкапсулирует логику для работы с продуктами в рамках проекта
    /// его зона ответственности:
    ///     сохранение / восстановление всех продуктов
    ///     добавление / удаление конкретного продукта
    ///     вывод списка продуктов
    /// </summary>
    internal static class ProductRepository
    {
        static string productsSaveFile = "products.json";
        static List<Product> products;

        static ProductRepository()
        {
            products = LoadData();
        }

        private static List<Product> LoadData() //восстановление списка продуктов из файл
        {
            if (!File.Exists(productsSaveFile))
            {
                Console.WriteLine("нет файла продуктов");
                return null;
            }
            string content = File.ReadAllText(productsSaveFile);
            var products = JsonSerializer.Deserialize<List<Product>>(content);
            return products;
        }
        public static void SaveData() //сохранение списка продуктов в файл
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string jsonString = JsonSerializer.Serialize(products, options);
            File.WriteAllText(productsSaveFile, jsonString);
        }
        static public void AddProduct() //добавление отдельного продукта
        {
            Console.WriteLine("введите название продукта");
            string name = Console.ReadLine();
            Console.WriteLine("введите цену продукта");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            
            if(price > 0 && name != null)
                products.Add(new Product { Name = name, Price = price });
            else
                Console.WriteLine("некорректные данные продукта");
        }

        public static  void ShowAllProducts() //вывод всех продуктов на текущую дату
        {
            Console.WriteLine("\n--------------------------------------\n" +
                $"продукты в системе на {DateTime.Now:g}\n" +
                $"--------------------------------------\n");
            int n = 1;
            foreach (var product in products)
                Console.WriteLine($"{n++}:\t{product.Name.PadRight(15)}цена: {product.Price:C}");
        }

        public static void DeleteProduct()
        {
            //создать метод для удаления продукта (самостоятельно продумать как - по индексу, по названию...
        }

    }
}
