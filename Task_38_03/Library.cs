using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_38_03
{
    public class Library
    {
        private List<Book> books = new();
        public List<Book> Books => books;
        private string saveFileName = "books.json";

        public void AddBook(Book book)
        {
            if (book != null)
            {
                books.Add(book);
                books.Sort();
            }
        }

        public void RemoveBook(Book book) 
        {
            if(books.Contains(book))
                books.Remove(book);
        } 

        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            var serializationData = JsonSerializer.Serialize(books, options);

            File.WriteAllText(saveFileName, serializationData);
        }

        public void Load()
        {
            if (!File.Exists(saveFileName))
                return;
            var data = File.ReadAllText(saveFileName);
            if(data != null)
                books = JsonSerializer.Deserialize<List<Book>>(data);
            else 
                books = new List<Book>();
        }
    }
}
