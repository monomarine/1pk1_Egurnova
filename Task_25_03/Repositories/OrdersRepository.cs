using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_03.Repositories
{
    internal static class OrdersRepository
    {
        static List<Order> orders;

        static OrdersRepository()
        {
           orders = LoadData();
        }

        private static List<Order> LoadData()
        {
            return null;
        }

        public static void SaveData()
        {

        }

        public static void CreateNewOrder()
        {

        }

        public static void ShowAllOrders()
        {

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
