namespace Task_21_03
{
    internal class Program
    {
        /*создайте класс Book и сгенерируйте список объектов книг (минимум 100 элементов). проанализируйте список и
        выведите:
        книгу с самым ранним годом издания (если их несколько то все)
        книгу с самым поздним годом издания (если их несколько то все)
        только книги в жанре «фантастика»
        только книги в состоянии «выданы на руки»*/
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            for (int i = 0; i < 100; i++)
            {
                var book = new Book();  
                books.Add(book);
                book.PrintInfo();
            }

           /*поиск самой ранней и поздней книги по году издания
            int minYear = int.MaxValue;
            int maxYear = int.MinValue;
            Book maxYearBook = new Book();
            Book minYearBook = new Book();
            foreach (var book in books)
            {
                if (book.Year <= minYear)
                { 
                    minYear = book.Year;
                    minYearBook = book;
                }
                if(book.Year >= maxYear) 
                {
                    maxYear = book.Year;
                    maxYearBook = book; 
                }
            }
            Console.WriteLine("\n\nкнига с минимальным годом издания");
            minYearBook.PrintInfo();
            Console.WriteLine("\nкнига с максимальным годом издания");
            maxYearBook.PrintInfo();
            */

            //вывод книг только в жанре фантастика:

            Console.WriteLine("\n\nвывод книг только в жанре фантастика:");
            foreach( var book in books)
            {
                if(book.Genre == Genre.Fantastic)
                    book.PrintInfo();
            }

            //вывод книг выданных на руки
            Console.WriteLine("\n\nвывод книг выданных на руки:");
            foreach (var book in books)
            {
                if (book.Status == BookStatus.Issued)
                    book.PrintInfo();
            }

            Console.WriteLine("самые старые книги:");
            List<Book> mins = GetMinYearBooks(books);
                foreach (var book in mins)
                book.PrintInfo();
        }
        // ДЗ. создать список для вывода всех самых новых книг (по году издания)
        static List<Book> GetMinYearBooks(List<Book> books)
        {
            int minYear = 3000;
            List<Book> minBooks = new(); //результирующий список

            foreach (var book in books) 
            {
                if(book.Year < minYear)
                    minYear = book.Year;
            }
            foreach (var book in books)
            {
                if(book.Year == minYear)
                    minBooks.Add(book);
            }
            return minBooks;
        }

    }
}
