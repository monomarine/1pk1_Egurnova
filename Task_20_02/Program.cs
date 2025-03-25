namespace Task_20_02
{
    internal class Program
    {
        /*Реализуйте консольную игру "Камень, Ножницы, Бумага" с использованием перечисления GameChoice:
        Rock
        Scissors
        Paper
        Компьютер выбирает случайный вариант.
        Игрок вводит свой выбор (например, цифрой: 1 – Камень, 2 – Ножницы и т. д.).
        Определите победителя на основе правил игры и выведите результат.
        */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Random random = new Random();

                GameChoice computerCoice = (GameChoice)random.Next(0, 4);

                Console.WriteLine("1 - камень\n" +
                    "2 - ножницы\n" +
                    "3 - бумага");

                int temp = Convert.ToInt32(Console.ReadLine());
                GameChoice playerChoice = (GameChoice)Math.Clamp(temp, 1, 3);

                PrintWinner(computerCoice, playerChoice);

                Console.ReadKey();
            }
        }

        public static void PrintWinner(GameChoice computer, GameChoice player)
        {
            if(computer == player)
            {
                Console.WriteLine( $"НИЧЬЯ (компьютер загадал - {computer})");
                return;
            }

            switch(player)
            {
                case GameChoice.Rock:
                    Console.WriteLine(computer == GameChoice.Scissors ? 
                        "Вы выиграли! у компьютера ножницы" :
                        "Вы проиграли! у компьютера бумага");
                    break;

                case GameChoice.Scissors:
                    Console.WriteLine(computer == GameChoice.Rock ?
                        "Вы проиграли! у компьютера камень":
                        "Вы выиграли! у компьютера бумага");
                    break;

                case GameChoice.Paper:
                    Console.WriteLine(computer == GameChoice.Rock ? 
                        "Вы выиграли! у компьютера камень" : 
                        "Вы проиграли! у компьютера ножницы");
                    break;
            }
        }
    }
}
