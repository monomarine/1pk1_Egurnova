using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task_25_06
{
    internal class Program
    {
        //сериализация коллекции
        static void Main(string[] args)
        {
            List<Car> cars = new()
            {
                new Car("B 888 BB 88", ConsoleColor.DarkBlue, "Иванов ИИ"),
                new Car("D 545 BB 56", ConsoleColor.Black, "Петров ПП"),
                new Car("K 875 HD 56", ConsoleColor.Gray, "Сидоров СС"),
            };
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };


            //сериализация коллекции
            string jsonString = JsonSerializer.Serialize(cars, options);
            File.WriteAllText("save.json", jsonString);
            Console.WriteLine(jsonString);

            //десериализация коллекции
            string content = File.ReadAllText("save.json");
            if(content != null)
            {
                List<Car> loadedCars = JsonSerializer.Deserialize<List<Car>>(content);
                
            }
        }
    }
}
