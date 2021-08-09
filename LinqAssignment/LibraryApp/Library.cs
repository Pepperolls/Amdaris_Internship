using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Library
    {
        public List<Book> BookCollection { get; }

        public Library()
        {
            BookCollection = new List<Book> { };
        }
        
        public void AddBookToCollection(Book book)
        {
            BookCollection.Add(book);
        }

        public void RemoveBookFromCollection(Book book)
        {
            BookCollection.Remove(book);
        }

        public List<Book> SeeBookCollection()
        {
            return BookCollection;
        }

        public List<Book> GetBooksPublishedAfter(DateTime publishYear)
        {
            return BookCollection.Where(p => p.PublishDate.Year > publishYear.Year).ToList();
        }

        public List<Book> GetBooksWithCategory(string category)
        {
            return BookCollection.Where(p => p.Categories.Contains(category)).ToList();
        }

        public List<string> GetAuthorsWithNumberOfBooks(int booksNumber)
        {
            List<Book> booksOfRequestedAuthors = BookCollection.Where(p => p.Author.BooksWritten.Count >= booksNumber).ToList();
            List<string> namesOfAuthors = booksOfRequestedAuthors.Select(p => p.Author.Name).ToList();
            return namesOfAuthors.Distinct().ToList();
        }
    }
}
