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
#pragma warning disable
        private List<Book> books = new(); //внутренняя (закрытая) коллекция книг
        public List<Book> Books => books; //свойство для чтения коллекции книг
        private string saveFileName = "books.json"; //название файла сохранения

        //	Добавление книги во внутреннюю коллекцию
        public void AddBook(Book book)
        {
            if (book != null) //исключаем возможность сохранения пустого объекта
            {
                books.Add(book); //добавляем книгку в коллекцию
                books.Sort(); //сортируем коллекцию
            }
        }

        //	Удаление книги из внутренней коллекции
        public void RemoveBook(Book book) 
        {
            if(books.Contains(book)) //проверяем наличие нужного объекта в коллекции
                books.Remove(book); //удаляяем объект из коллекции
        } 
        
        //Сохранение всей коллекции в файле
        public void Save()
        {
            //параметры сериализации
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            //сериализация данных
            var serializationData = JsonSerializer.Serialize(books, options);
            //запись в файл
            File.WriteAllText(saveFileName, serializationData);
        }
        // Загрузка ранее сохраненных данных из файла в коллекцию
        public void Load()
        {
            if (!File.Exists(saveFileName)) //проверка на существование файла
                return; //если его нет - метод останавливается
            
            //чтение данных из файла
            var data = File.ReadAllText(saveFileName);
            //если входные данные не пустые - десериализуем в коллекцию books
            if(data != null)
                books = JsonSerializer.Deserialize<List<Book>>(data);
            else //в противном случае просто делаем новую пустую коллекцию
                books = new List<Book>();
        }
    }
}
