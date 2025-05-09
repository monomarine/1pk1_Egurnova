using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_03
{
#pragma warning disable
    public class Book : IComparable
    {
        public string Title { get; private set; } //название
        public string Author { get; private set; } //автор
        public int YearOfPublication { get; private set; } //год издания
        public BookState State { get; private set; } //состояние

        //конструтор
        public Book(string title, string author, int yearOfPublication, BookState state)
        {
            Title = title;
            Author = author;
            YearOfPublication = yearOfPublication;
            State = state;
        }
        //вывод информации о книге
        public override string ToString()
        {
            return $"{Author} - \"{Title}\" ({YearOfPublication})";
        }
        //метод-конвертер для русскоязычного вывода состояния книги
        public string StringState()
        {
            switch (State)
            {
                case BookState.Great: return "отличное"; break;
                case BookState.Normal: return "нормальное"; break;
                case BookState.Bad: return "плохое"; break;
            }
            return null;
        }

        public int CompareTo(object? obj)
        {
            if (obj != null && obj is Book book)
            {
                return (Author + Title).CompareTo(book.Author + book.Title);
            }
            else
                throw new ArgumentException();
        }
    }
}
