using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Author
    {
        public Author(int id, string name, DateTime birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            BooksWritten = new List<Book> { };
        }

        public void WriteBook(Book book)
        {
            BooksWritten.Add(book);
        }

        public int Id { get; }
        public string Name { get; }
        public DateTime BirthDate { get; }
        public List<Book> BooksWritten { get; }

        public List<Book> SeeBooksWritten()
        {
            return BooksWritten;
        }

        public override string ToString()
        {
            return $"Name: {Name}, BirthDate: {BirthDate}";
        }
    }
}
