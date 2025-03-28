using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_05
{
    //на основе словаря реализуйте систему бронирования билетов на поезд.
    //предусмотрите резервирование незанятого места,
    //невозможность купить место, уже занятое другим пассажиром,
    //возможность вернуть билет(освободить место)
    internal class TrainSystem
    {
        private Dictionary<int, string> tickets;

        public TrainSystem()
        {
            tickets = new Dictionary<int, string>();
            for (int i = 1; i < 31; i++) 
            {
                tickets[i] = "";
            }
        }
        //предусмотрите резервирование незанятого места,
        public void ReserveTicket(int ticketNumber, string passangerName)
        {
            if (tickets[ticketNumber] == "")//билет не зарезервирован
            {
                tickets[ticketNumber] = passangerName;
                Console.WriteLine($"пассажир {passangerName} успешно забронировал место {ticketNumber}");
            }
            else
                Console.WriteLine($"место уже зарезервировано пассажиром {tickets[ticketNumber]}"); ;
        }


        public void ReturnTicket(int ticketNumber)
        {
            if (tickets[ticketNumber] == "")
            {
                Console.WriteLine("невозможно вернуть билет, т.к. он в продаже");
            }
            else
            {
                tickets[ticketNumber] = "";
                Console.WriteLine("билет успешно возвращен");
            }
        }

    }
}
