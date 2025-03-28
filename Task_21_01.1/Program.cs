using static System.Net.Mime.MediaTypeNames;

namespace Task_21_01._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> text = new List<string>
            {
                "111111111111",
                "222222222222",
                "333333333333",
                "444444444444"
            };

           /*
            while(true)
            {
                string temp = Console.ReadLine();
                if (temp == "stop")
                    break;
                else
                    text.Add(temp);
            }
           */

            PrintList(text);

            //удаление из списка с индекса 2
            if (text.Count > 3)
                text.RemoveAt(2);

            Console.WriteLine("список после удаления элемента под индексом 2");
            PrintList(text);


            Console.WriteLine();
            //вставка на определенную позицию
            text.Insert(2,"aaaaaaaaaaaaaaaaaaaaaa");
            PrintList(text);
        }

        static void PrintList(List<string> list)
        {
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
