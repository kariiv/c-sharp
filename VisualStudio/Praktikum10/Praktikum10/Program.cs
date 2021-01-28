using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum10
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Blindness";//uses Title set method
            book1.Genre = BookGenre.ScienceFiction; //uses Genre set method
            book1.ReleaseYear = 1865;
            book1.Author = "Mrs. Mary";

            Console.WriteLine(book1.Title); //uses Title get method
            Console.WriteLine(book1.Genre); //uses Genre get method

            Book book2 = new Book();
            book2.Title = "Magic mountain";//uses Title set method
            book2.Genre = BookGenre.ScienceFiction;//uses Genre set method
            book2.ReleaseYear = 1980;
            book2.Author = "Mart Est";

            Book book3 = new Book();
            book3.Title = "Magic";//uses Title set method
            book3.Genre = BookGenre.Drama;//uses Genre set method
            book3.ReleaseYear = 1967;
            book3.Author = "Mick Stick";

            Book book4 = new Book("Big Papa");
            book4.Genre = BookGenre.Comedy;
            book4.ReleaseYear = 1999;
            book4.Author = "Mark Surk";

            Book book5 = new Book("Drama", "Raina Telgemeier");
            book5.Genre = BookGenre.Drama;
            book5.ReleaseYear = 1987;

            Book book6 = new Book("The Adventures of Tom Sawyer", "Mark Twain");
            book6.Genre = BookGenre.Adventure;
            book6.ReleaseYear = 2012;

            Book book7 = new Book("Blalaa");
            book7.Genre = BookGenre.Comedy;
            book7.Author = "Mark Sista";
            book7.ReleaseYear = 1906;

            Book book8 = new Book("Alive");
            book8.Genre = BookGenre.Horror;
            book8.ReleaseYear = 1986;
            book8.Author = "Sandra Astastoni";

            Book book9 = new Book("The Hunger Games", "Suzanne Collins");
            book9.Genre = BookGenre.Adventure;
            book9.ReleaseYear = 2008;

            Book book10 = new Book("the hitchhiker's guide to the galaxy", "Douglas Adams");
            book10.Genre = BookGenre.Comedy;
            book10.ReleaseYear = 1942;

            //create a new library
            Library library = new Library("New York's Main");

            //add 3 books to library
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            library.AddBook(book7);
            library.AddBook(book8);
            library.AddBook(book9);
            library.AddBook(book10);

            //find all books that contain a certain name and store them in a list
            List<Book> allBooksThatContainDarkness = library.FindAllBooksByName("Magic");

            //lets print them out to be sure of the results
            library.PrintAllBooksByName("Magic");

            //borrowing a book


            //the book is present in library and not borrowed out, we can borrow it
            bool canBorrow = library.BorrowBook("Darkness 2");
            //this book is borrowed out, cant borrow again
            bool canBorrowAgain = library.BorrowBook("Sci-fi");

            //printing all book titles
            library.PrintAllBookTitlesInLibrary();
            
            library.PrintAllBooksAfterReleasedYear(1500);
            
            library.PrintAllBooksByAuthor("Mark");

            Console.ReadLine();

        }
    }
}
