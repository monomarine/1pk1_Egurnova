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
            //переменные для хранения логина и пароля
            string login = "";
            string password = "";

            while (true)
            {
                Console.Clear(); //очистка консоли

                //информационное сообщение пользователю. (старайтей дать инструкцию
                //пользователю для работы
                Console.WriteLine("выберите желаемое действие\n" +
                    "\t 1 - зарегестрироваться\n" +
                    "\t 2 - сменить логин\n" +
                    "\t 3 - сменить пароль\n" +
                    "\t 4 - удалить учетку.\n" +
                    "\t 5 - проверить данные");

                //переменная для считывания выбранного режима работы
                string? mode = Console.ReadLine();

                switch (mode)
                {
                    case "1": //ветка регистрации пользователя

                        Console.WriteLine("введите логин нового пользователя");
                        string? tempLogin = Console.ReadLine();  //временная переменная для нового логина
                                                                 //проверка - если пользователь ввел не тот же самый логин и не пустой
                        login = tempLogin; //перезапись логина
                        
                        Console.WriteLine("введите пароль нового пользователя");
                        string? tempPass = Console.ReadLine();  //временная переменная для нового логина
                                                                //проверка - если пользователь ввел не тот же самый пароль и не пустой
                        password = tempPass; //перезапись пароля
                        break;

                    case "2": // смена логина
                        if (login != null)
                            Console.WriteLine("ваш текущий логин - " + login +
                                "\nвведите новый логин");
                        tempLogin = Console.ReadLine();
                        if (tempLogin != login && tempLogin != null)
                            login = tempLogin;
                        else
                            Console.WriteLine("введен некорректный логин");
                        break;

                    case "3": // смена пароля
                        if (password != null)
                            Console.WriteLine("ваш текущий пароль - " + password +
                                "\nвведите новый пароль");
                        tempPass = Console.ReadLine();
                        if (tempPass != login && tempPass != null)
                            password = tempPass;
                        else
                            Console.WriteLine("введен некорректный пароль");
                        break;

                    case "4": // удаление учетки
                        login = "";
                        password = "";
                        Console.WriteLine("данные удалены");
                        break;

                    case "5": //проверка данных
                        Console.WriteLine("ваш логин: " + login +
                            "\nваш пароль: " +password);
                        break;

                    default:
                        Console.WriteLine("вы выбрали некорректный режим");
                        break;
                }
                Console.ReadKey();
            }

        }
    }
}
