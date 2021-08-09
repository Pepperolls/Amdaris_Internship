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
            Id = id;
            Title = title;
            PublishDate = publishDate;
            Author = author;
            Categories = categories;
        }

        public int Id { get; }
        public string Title { get; }
        public DateTime PublishDate { get; }
        public Author Author { get; }
        public List<string> Categories { get; }

        public string GetAuthorName()
        {
            return Author.Name;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author.Name}";
        }
    }
}
