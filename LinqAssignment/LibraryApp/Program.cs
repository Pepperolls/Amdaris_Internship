using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library lib1 = new Library();

            DateTime birthDate1 = new DateTime(2001, 08, 12, 08, 0, 0);
            DateTime birthDate2 = new DateTime(1989, 08, 12, 08, 0, 0);

            DateTime publishDate1 = new DateTime(2019, 01, 01, 0, 0, 0);
            DateTime publishDate2 = new DateTime(2020, 01, 01, 0, 0, 0);
            DateTime publishDate3 = new DateTime(2021, 01, 01, 0, 0, 0);

            DateTime date4 = new DateTime(2019, 01, 01, 00, 0, 0);
            DateTime date5 = new DateTime(2019, 01, 01, 00, 0, 0);

            List<string> categories1 = new List<string>
            {
                "Horror",
            };

            List<string> categories2 = new List<string>
            {
                "Drama",
                "Horror"
            };

            List<string> categories3 = new List<string>
            {
                "Drama",
                "Horror",
                "Action"
            };

            Author author1 = new Author(1, "Rares", birthDate1);
            Author author2 = new Author(2, "Tudor", birthDate2);

            Book book1 = new Book(1, "Light weight", publishDate1, author1, categories1);
            author1.WriteBook(book1);

            Book book2 = new Book(2, "Light weight baby", publishDate2, author1, categories2);
            author1.WriteBook(book2);

            Book book3 = new Book(3, "Light", publishDate2, author1, categories3);
            author1.WriteBook(book3);

            Book book4 = new Book(4, "JavaScript Basics", publishDate3, author2, categories2);
            author2.WriteBook(book4);

            lib1.AddBookToCollection(book1);
            lib1.AddBookToCollection(book2);
            lib1.AddBookToCollection(book3);
            lib1.AddBookToCollection(book4);

            //lib1.SeeBookCollection().ForEach(Console.WriteLine);

            //lib1.RemoveBookFromCollection(book1);
            //lib1.SeeBookCollection().ForEach(Console.WriteLine);

            //lib1.GetBooksPublishedAfter(publishDate1).ForEach(Console.WriteLine);

            //lib1.GetBooksWithCategory("Drama").ForEach(Console.WriteLine);

            lib1.GetAuthorsWithNumberOfBooks(3).ForEach(Console.WriteLine);
        }
    }
}
