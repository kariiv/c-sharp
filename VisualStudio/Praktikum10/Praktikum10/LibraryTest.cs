using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Praktikum10
{
    [TestFixture]
    class LibraryTest
    {
        Book book1, book2, book3, book4, book5, book6, book7, book8, book9, book10;
        Library myLibrary;

        [SetUp]
        public void CreateObjects()
        {
            book1 = new Book("Magic mountain");
            book1.Genre = BookGenre.ScienceFiction;

            book2 = new Book("Magic");
            book2.Genre = BookGenre.ScienceFiction;

            book3 = new Book("Blindness");
            book3.Genre = BookGenre.Drama;
            book3.ReleaseYear = 1967;

            book4 = new Book("Big Papa");
            book4.Genre = BookGenre.Comedy;
            book4.Author = "Mark Surk";

            book5 = new Book("Drama", "Raina Telgemeier");
            book5.Genre = BookGenre.Drama;

            book6 = new Book("The Adventures of Tom Sawyer", "Mark Twain");
            book6.Genre = BookGenre.Adventure;

            book7 = new Book("Blalaa");
            book7.Genre = BookGenre.Comedy;
            book7.Author = "Mark Sista";

            book8 = new Book("Alive");
            book8.Genre = BookGenre.Horror;

            book9 = new Book("The Hunger Games", "Suzanne Collins");
            book9.Genre = BookGenre.Adventure;

            book10 = new Book("the hitchhiker's guide to the galaxy", "Douglas Adams");
            book10.Genre = BookGenre.Comedy;
            book10.ReleaseYear = 1942;

            myLibrary = new Library("Local City");
        }

        [Test]
        public void AddBook_Add1BookToLibrary()
        {
            myLibrary.AddBook(book1);
            Assert.AreEqual(myLibrary.GetNumberOfBooksInLibrary(), 1);
        }

        [Test]
        public void TestFinding1Book()
        {
            myLibrary.AddBook(book1);
            Assert.AreEqual(book1.Title, myLibrary.FindBookByName("Ma").Title);
        }

        [Test]
        public void TestFindingBookByGenre_SciFi()
        {
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            myLibrary.AddBook(book3);

            List<Book> books =
                myLibrary.FindAllBooksWithCertainGenre(BookGenre.ScienceFiction);

            Assert.AreEqual(books.Count, 2);
        }

        [Test]
        public void BorrowBook_DidBookStatusChange()
        {
            myLibrary.AddBook(book1);
            myLibrary.BorrowBook("Magic mountain");
            Assert.IsTrue(book1.GetBorrowedStatus() == true);
        }

        [Test]
        public void BorrowBook_WasBorrowingSuccesful()
        {
            myLibrary.AddBook(book1);
            bool canBorrow = myLibrary.BorrowBook("Magic mountain");
            Assert.IsTrue(canBorrow);
        }

        [Test]
        public void BorrowBook_CantBorrowAlreadyBorrowedBook()
        {
            myLibrary.AddBook(book1);
            bool canBorrow = myLibrary.BorrowBook("Sci-fi 1");
            //this book is already borrowed out, cant borrow again
            bool canBorrowAgain = myLibrary.BorrowBook("Sci-fi 1");
            Assert.IsFalse(canBorrowAgain);
        }

        [Test]
        public void GetAllBooksThatContain_Mag_InTitle()
        {
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            List<Book> allBooksThatContainSci = myLibrary.FindAllBooksByName("Mag");
            Assert.IsTrue(allBooksThatContainSci.Count == 2);
        }

        [Test]
        public void LibraryNameTest()
        {
            Assert.AreEqual(myLibrary.Name ,"Local City");
        }
        
        [Test]
        public void BookReleaseYearTest()
        {
            book1.ReleaseYear = 2001;
            Assert.IsTrue(book1.ReleaseYear == 2001);
        }

        [Test]
        public void CountBooksByReleaseYears()
        {
            myLibrary.AddBook(book3);
            myLibrary.AddBook(book10);
            List<Book> books = myLibrary.GetBooksReleaseAfterYear(1500);
            Assert.AreEqual(books.Count, 2);
        }

        [Test]
        public void CountBooksByAuthorTest()
        {
            myLibrary.AddBook(book4);
            myLibrary.AddBook(book6);
            myLibrary.AddBook(book7);
            List<Book> books = myLibrary.FindAllBooksByAuthor("Mark");
            Assert.AreEqual(books.Count, 3);
        }

        [Test]
        public void CountBooksByAuthorTest2()
        {
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            myLibrary.AddBook(book3);
            List<Book> books = myLibrary.FindAllBooksByAuthor("Isabel");
            Assert.AreEqual(books.Count, 0);
        }

        [Test]
        public void LibraryAddress()
        {
            myLibrary.Address = "Kaksikivi tee 14";
            Assert.AreEqual(myLibrary.Address, "Kaksikivi tee 14");
        }


    }
}
