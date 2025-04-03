using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_03
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }

        public List<Product> Products { get; set; } = new();

        public decimal GetTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (var product in Products)
                totalAmount += product.Price;
            return totalAmount;
        }
    }
}
