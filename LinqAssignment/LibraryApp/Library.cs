﻿using System;
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
            var booksAfter = BookCollection.Where(Book => Book.PublishDate.Year > publishYear.Year);
            return booksAfter.ToList();
        }
    }
}
