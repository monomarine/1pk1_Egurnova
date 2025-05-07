using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_02
{
    /// <summary>
    /// класс отдельного продукта - содержит название и цену
    /// </summary>
    internal class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Product(string title, decimal price)
        {
            Title = title; 
            Price = price;
        }
        /// <summary>
        /// переопредяем ToString для того чтобы в список выводилоась информация в нужном нам виде (и название и цена)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Title}: {Price:F2}";
        }
    }
}
