using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Library
{
    [TestFixture]
    class LibraryTest
    {
        Book book1, book2, book3;
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

            myLibrary = new Library();
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
            Assert.AreEqual(book1.Title, myLibrary.FindBookByName("Sci").Title);
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
            myLibrary.BorrowBook("Sci");
            Assert.IsTrue(book1.GetBorrowedStatus() == true);
        }

        [Test]
        public void BorrowBook_WasBorrowingSuccesful()
        {
            myLibrary.AddBook(book1);
            bool canBorrow= myLibrary.BorrowBook("Sci");
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
        public void GetAllBooksThatContain_Sci_InTitle()
        {
            myLibrary.AddBook(book1);
            myLibrary.AddBook(book2);
            List<Book> allBooksThatContainSci = myLibrary.FindAllBooksByName("Sci");
            Assert.IsTrue(allBooksThatContainSci.Count==2);
        }
    }
}
