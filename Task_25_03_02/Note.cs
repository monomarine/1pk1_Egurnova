using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Category { Important, NotImportant}

    internal class Note
    {
        public string Text { get; set; }
        public Category Category { get; set; }

        public Note (string text, Category category)
        {
            Text = text;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Text}\n" +
                $"категория - {Category}";
        }
    }
}
