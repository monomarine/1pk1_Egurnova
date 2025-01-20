namespace Task_03_10
{
    internal class Program
    {
        /*
         * пользователь в бесконечном цикле осуществляет
         * построчный ввод. 
         * цикл останавливается при условие ввода пустой строки
         * или стоки "exit" или "stop"
         * после чего пользователю выводится количество строк, который он вводил
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("какой символ будем считать в тексте?");
            char symbol = char.Parse(Console.ReadLine());   

            Console.WriteLine("осуществите ввод текста построчно");
            int countOfChar = 0;

            while (true)
            {
                string temp = Console.ReadLine();
                if (temp == "" || temp == "stop" || temp == "exit")
                    break;

                foreach (char ch in temp)
                {
                    if (ch == symbol)
                        countOfChar++;
                }
 
            }
            Console.WriteLine("вы ввели " + countOfChar + " символов " + symbol);
        }
    }
}
