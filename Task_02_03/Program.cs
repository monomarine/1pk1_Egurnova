namespace Task_02_03
{
    internal class Program
    {
        /*
         Программа эмулирует регистрацию в системе. Пользователь выбирает действие среди доступных:
            Зарегистрироваться
            Сменить логин
            Сменить пароль
            Удалить учетку
        В зависимости от выбранного режима произвести соответствующие действия с пользовательскими данными и выведите соответствующие сообщения.

         */
        static void Main(string[] args)
        {
            Console.WriteLine("выберите желаемое действие\n" +
                "\t 1 - зарегестрироваться\n" +
                "\t 2 - сменить логин\n" +
                "\t 3 - сменить пароль\n" +
                "\t 4 - удалить учетку.");

            int mode = Int32.Parse(Console.ReadLine());
            switch(mode)
            {
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break ;
            }

        }
    }
}
