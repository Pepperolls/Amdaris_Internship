using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Book
    {
        public Book(int id, string title, DateTime publishDate, Author author, List<string> categories)
        {
            this.Id = id;
            this.Title = title;
            this.PublishDate = publishDate;
            this.Author = author;
            this.Categories = categories;
        }

        public int Id { get; }
        public string Title { get; }
        public DateTime PublishDate { get; }
        public Author Author { get; }
        public List<string> Categories { get; }
    }
}
