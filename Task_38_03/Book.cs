using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_03
{
    public class Book : IComparable
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int YearOfPublication { get; private set; }
        public BookState State { get; private set; }


        public Book(string title, string author, int yearOfPublication, BookState state)
        {
            Title = title;
            Author = author;
            YearOfPublication = yearOfPublication;
            State = state;
        }
        public override string ToString()
        {
            return $"{Author} - \"{Title}\" ({YearOfPublication})";
        }

        public int CompareTo(object? obj)
        {
            if (obj is Book book)
            {
                return (Author+Title).CompareTo(book.Author+book.Title);
            }
            else
                throw new ArgumentException("невозможно сравнить. объект не является книгой");
        }

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
    }
}
