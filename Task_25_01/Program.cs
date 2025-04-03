using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Task_25_01
{
    internal class Program
    {
        //демонстрация сериализации на примере простого класса
        static void Main(string[] args)
        {
            string fileName = "data.json";

            TestClass test = new TestClass()
            {
                Title = "тестовый объект",
                Number = 5459,
                Status = Status.Low,
                Date = DateTime.Now,
            };

            string jsonString = JsonSerializer.Serialize<TestClass>(test); //сериализация
            Console.WriteLine(jsonString);//предпросмотр

            File.WriteAllText(fileName, jsonString);//запись в файл

            Process.Start("notepad.exe", fileName);//открытие проводника с файлом для быстроты проверки


            string jsonStringFromFile = File.ReadAllText(fileName);//считывание данных из файла

            //кому интересно про ?? - null-объединение - можно забежать вперед почитать. но можно обойтись и закоментированной строкой?
            //TestClass test2 = JsonSerializer.Deserialize<TestClass>(jsonStringFromFile);
            TestClass test2 = JsonSerializer.Deserialize<TestClass>(jsonStringFromFile) ?? new TestClass();

            Console.WriteLine($"объект {nameof(test2)}\n" +
                $"статус: {test2.Status}\n" +
                $"заголовок: {test2.Title}");
        }
    }
}
