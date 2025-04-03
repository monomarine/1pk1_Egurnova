using System.Text.Json;

namespace Task_25_02
{
    internal class Program
    {
        /*
        создать пользователя для текущего сеанса. сериализовать его данные в файл
        при перезапуске запросить логин и пароль и сверить с данными из файла
        */

        #pragma warning disable
        static void Main(string[] args)
        {
            string fileName = "User.json";
            User user = new User("Admin", "admin");

            //сериализация объекта пользователя в строку
            string jsonString = JsonSerializer.Serialize(user);

            //запись сериализованных данных в файл
            File.WriteAllText(fileName, jsonString);

            //запрос данных от пользователя для "авторизации"
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            //считывание данных из файла
            string temp = File.ReadAllText(fileName);

            //десериализация объекта пользователя (восстановление) - но
            //в памяти будет новый объект пользователя
            //с теми же самыми данными
            User savedUser = JsonSerializer.Deserialize<User>(temp);
            
            //проверка совпадения введенной пользователем информации и полученной из файла
            if (login == savedUser.Login && password == savedUser.Password)
                Console.WriteLine("Успешная авторизация");
            else
                Console.WriteLine("Неверные данные");
        }
    }
}
