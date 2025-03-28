namespace Task_21_05
{
    internal class Program
    {
        //на основе словаря реализуйте систему бронирования билетов на поезд.
        //предусмотрите резервирование незанятого места,
        //невозможность купить место, уже занятое другим пассажиром,
        //возможность вернуть билет(освободить место)

        static void Main(string[] args)
        {
            TrainSystem train = new TrainSystem();

            train.ReserveTicket(10, "Иванов");
        }
    }
}
