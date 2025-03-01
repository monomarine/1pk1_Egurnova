using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_01
{
    internal class Item :IDisposable
    {
        #region static
        private static int itemsCount = 0;
        public static void GetItemsCount()
        {
            Console.WriteLine($"количество объектов - {itemsCount}");
        }

        public void Dispose()
        {
            itemsCount--;
        }
        #endregion
        int id;
        string title;

        public int ID => id;
        public string Title => title; 
        
        public Item(string title)
        {
            this.title = title; 
            itemsCount++;
        }
        public Item(int id, string title)
        {
            this.id=id;
            this.title=title;
            itemsCount ++;  
        }
        public Item() 
        {
            itemsCount++;
        }

    }
}
