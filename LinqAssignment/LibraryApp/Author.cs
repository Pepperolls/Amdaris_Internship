using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Author
    {
        public Author(int id, string name, DateTime birthDate, List<string> publishedBooks)
        {
            this.Id = id;
            this.Name = name;
            this.BirthDate = birthDate;
            this.PublishedBooks = publishedBooks;
        }

        public int Id { get; }
        public string Name { get; }
        public DateTime BirthDate { get; }
        public List<string> PublishedBooks { get; }
    }
}
