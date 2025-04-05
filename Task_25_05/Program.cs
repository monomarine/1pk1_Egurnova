using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task_25_05
{
    internal class Program
    {
        static User currentUser = new("admin", "123456");
        static string txtFile = "save.txt";
        static string jsonFile = "save.json";
        static void Main(string[] args)
        {
            SaveDataToJson();
            User user = LoadFromJson();
            Console.WriteLine(user.Login + " " + user.Password);
        }

        public static void SaveDataToTxt()
        {
            using (StreamWriter write = new StreamWriter(txtFile))
            {
                write.WriteLine(currentUser.Login);
                write.WriteLine(currentUser.Password);
            }
        }

        public static User LoadFromTxt()
        {
            if (File.Exists(txtFile))
            {
                using (StreamReader read = new StreamReader(txtFile))
                {
                    return new User(read.ReadLine(), read.ReadLine());
                }
            }
            else
                return null;
        }

        public static void SaveDataToJson()
        {
            string jsonString = JsonSerializer.Serialize<User>(currentUser);
            //Console.WriteLine(jsonString);
            File.WriteAllText(jsonFile, jsonString);
        }

        public static User LoadFromJson()
        {
            string jsonString = File.ReadAllText(jsonFile);
            User loadedUser = JsonSerializer.Deserialize<User>(jsonString);
            return loadedUser;
        }
    }
}
