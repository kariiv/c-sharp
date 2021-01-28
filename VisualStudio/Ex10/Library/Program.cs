using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Blindness";//uses Title set method
            book1.Genre = BookGenre.ScienceFiction; //uses Genre set method

            Console.WriteLine(book1.Title); //uses Title get method
            Console.WriteLine(book1.Genre); //uses Genre get method



            Book book2 = new Book();
            book2.Title = "Magic mountain";//uses Title set method
            book2.Genre = BookGenre.ScienceFiction;//uses Genre set method

            Book book3 = new Book();
            book3.Title = "Magic";//uses Title set method
            book3.Genre = BookGenre.Drama;//uses Genre set method

            //create a new library
            Library library = new Library();

            //add 3 books to library
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

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

            Console.ReadLine();
        }
    }
}
