namespace Task_03_02
{
    internal class Program
    {
        /*игра "угадай-ка" программа загадывает число, 
         * пользователь за конечное число шагов должен 
         * это число угадать в случае неправильного ответа 
         * программа подсказывает, больше ли введенное 
         * число относительно загаданного или меньше
*/
        static void Main(string[] args)
        {
            Random rnd = new Random(); //объект рандома
            int countOfAttempt = 5; //количество попыток
            int x = rnd.Next(100); //компьютер загадывает число

            Console.WriteLine("отгадайте числов в диапазоне от 0 до 100 за 5 попыток");
            for (int i = 0; i < countOfAttempt; i++) //цикл ограничен количеством попыток
            {
                int userAttempt = int.Parse(Console.ReadLine()); //считывает ответ пользователя
                if (userAttempt == x) //если пользователь ввел загаданное число
                {
                    Console.WriteLine("Угадали!");
                    break;
                }
                else if (userAttempt > x) //подсказка
                    Console.WriteLine("неправильно, загаданное число меньше");
                else Console.WriteLine("неправильно, загаданное число больше"); //подстказка
            }

            Console.WriteLine("загаданное число - " + x);

        }
    }
}
