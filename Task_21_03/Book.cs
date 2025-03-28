using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_03
{
    /* книгу с самым ранним годом издания (если их несколько то все)
        книгу с самым поздним годом издания (если их несколько то все)
        только книги в жанре «фантастика»
        только книги в состоянии «выданы на руки»*/

    enum BookStatus { Issued, Available }
    enum Genre { Adventure, Fantastic, Fantasy, Liryc, Horror, Romantic}
    internal class Book
    {
        public int Year {  get; set; }  
        public BookStatus Status { get; set; }
        public Genre Genre { get; set; }

        public Book()
        {
            Random random = new Random();
            Year = random.Next(2000, 2026);
            Status = (BookStatus)random.Next(0,2);
            Genre = (Genre)random.Next(0, 6);
        }

        public void PrintInfo()
        {
            string description = $"книга {Year} года издания. Жанр - {Genre}\n";
            string status = Status == BookStatus.Available ?
                "доступна для выдачи" :
                "находится на руках у читателя";

            Console.WriteLine(description + status);
        }
    }
}
