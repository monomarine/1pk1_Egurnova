using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_25_03
{
    internal enum Mode //перечисление для режимов работы приложения
    {
        Exit = 0,
        CreateNewOrder = 1,
        ShowAllOrders = 2,
        ShowAllProducts = 3,
        AddProduct = 4,
        DeleteProduct = 5,
        TotalRevenue = 6,
        DayRevenue = 7
    }
}
