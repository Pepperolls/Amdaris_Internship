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
            DateTime publishDate1 = new DateTime(2019, 01, 01, 0, 0, 0);
            DateTime publishDate2 = new DateTime(2020, 01, 01, 0, 0, 0);
            DateTime date4 = new DateTime(2019, 01, 01, 00, 0, 0);
            DateTime date5 = new DateTime(2019, 01, 01, 00, 0, 0);

            List<string> categories1 = new List<string>
            {
                "Drama",
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
            Book book1 = new Book(1, "Light weight", publishDate1, author1, categories1);
            author1.WriteBook(book1);

            Book book2 = new Book(2, "Light weight baby", publishDate2, author1, categories2);
            author1.WriteBook(book2);

            lib1.AddBookToCollection(book1);
            lib1.AddBookToCollection(book2);
            //lib1.SeeBookCollection().ForEach(Console.WriteLine);

            //lib1.RemoveBookFromCollection(book1);
            //lib1.SeeBookCollection().ForEach(Console.WriteLine);

            lib1.GetBooksPublishedAfter(publishDate1).ForEach(Console.WriteLine);
           
        }
    }
}
