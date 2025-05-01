using System.CodeDom.Compiler;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static string fileName = "Notes.json";
        static void Main(string[] args)
        {
            Generate();
            var nodes = LoadNotes();

            foreach (var node in nodes)
            {
                Console.WriteLine("до смены категории: " + node);
                node.Category = node.Category == Category.NotImportant ?
                     Category.Important :
                     Category.NotImportant;

                Console.WriteLine("после смены категории: " + node);
            }

            SaveNodes(nodes);
        }

        private static void Generate()
        {
            List<Note> notes = new()
            {
                new Note("сделать ДЗ по программированию", Category.Important),
                new Note("отдыхать!", Category.NotImportant),
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
           
            string jsonString = JsonSerializer.Serialize(notes, options);
            File.WriteAllText(fileName, jsonString);
        }

        private static List<Note> LoadNotes()
        {
           return JsonSerializer.Deserialize<List<Note>>(File.ReadAllText(fileName));  
        }

        private static void SaveNodes(List<Note> notes)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            File.WriteAllText(fileName, JsonSerializer.Serialize(notes, options));
        }
    }
}
