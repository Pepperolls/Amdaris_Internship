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

            DateTime birthDate1 = new DateTime(1980, 08, 12, 08, 0, 0);
            DateTime birthDate2 = new DateTime(1999, 10, 13, 10, 0, 0);

            DateTime publishDate1 = new DateTime(1980, 01, 01, 0, 0, 0);
            DateTime publishDate2 = new DateTime(2010, 01, 01, 0, 0, 0);
            DateTime publishDate3 = new DateTime(2021, 01, 01, 0, 0, 0);
            DateTime publishDate4 = new DateTime(2022, 01, 01, 0, 0, 0);


            List<string> categories1 = new()
            {
                "Horror",
            };

            List<string> categories2 = new()
            {
                "Drama",
                "Horror",
                "Science-fiction"
            };

            List<string> categories3 = new()
            {
                "Drama",
                "Science-fiction",
                "Action"
            };

            List<string> categories4 = new()
            {
                "Web design",
                "Horror"
            };

            List<string> categories5 = new()
            {
                "HTML",
                "Horror"
            };

            Author author1 = new Author(1, "Rares", birthDate1);
            Author author2 = new Author(2, "Tudor", birthDate2);

            Book book1 = new Book(1, "Light weight", publishDate1, author1, categories1);
            author1.WriteBook(book1);
            lib1.AddBookToCollection(book1); 
            

            Book book2 = new Book(2, "Light weight baby", publishDate2, author1, categories2);
            author1.WriteBook(book2);
            lib1.AddBookToCollection(book2);

            Book book3 = new Book(3, "Light", publishDate2, author1, categories3);
            author1.WriteBook(book3);
            lib1.AddBookToCollection(book3);

            Book book4 = new Book(4, "Web Design Basics", publishDate3, author2, categories4);
            author2.WriteBook(book4);
            lib1.AddBookToCollection(book4);

            Book book5 = new Book(5, "HTML Basics", publishDate4, author2, categories5);
            author2.WriteBook(book5);
            lib1.AddBookToCollection(book5);


            // lib1.SeeBookCollection().ForEach(Console.WriteLine);

            // lib1.RemoveBookFromCollection(book1);

            // lib1.SeeBookCollection().ForEach(Console.WriteLine);

            // lib1.GetBooksPublishedAfter(1980).ForEach(Console.WriteLine); 

            // lib1.GetBooksWithCategory("Drama").ForEach(Console.WriteLine);

            // lib1.GetAuthorsWithNumberOfBooks(3).ForEach(Console.WriteLine);

            // lib1.GetAuthorsByBirthYearAndCategory(1990, "Science-fiction", 2).ForEach(Console.WriteLine);

            /*
            var groupedByDecade = lib1.GroupBooksByDecade();
            foreach(var group in groupedByDecade)
            {
                Console.WriteLine(group.Key + "'s");
                foreach(var book in group)
                {
                    Console.WriteLine(book);
                }
            }
            */
        }
    }
}

// I have chosen to create a method inside the Author class - Author.WriteBook - in order to not have a circular dependency between the author
// and the book, since an author has a list of written books and a book has an author. 
// The logic behind this is the fact that an author can live without a written book (althought he might not be an author anymore), while a book
// can't be created without having an author.
// I have commented all the requested features' testing part, leaving only the declarations available, because otherwise it would be a mess in the console log
// afterwards. They are put in order, so whenever you want to test one of them, it's easier. Also I believe their names are suggestive enough.
// I got rid of all the cases where there were hard-coded parameters, and chose to only use arguments.