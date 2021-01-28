using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum10
{
    public enum BookGenre { Horror, ScienceFiction, Romance, Drama, Comedy, Adventure }
    class Book
    {
        private string _title; //private field
        private string _author;
        private int _releaseYear;
        private BookGenre _genre; //private field
        bool _isBorrowed; //private field

        public Book()
        {
            _isBorrowed = false;
        }
        public Book(string title)
        {
            _isBorrowed = false;
            _title = title;
        }

        public Book(string title, string author)
        {
            _isBorrowed = false;
            _title = title;
            _author = author;
        }

        public BookGenre Genre //public property 
        {
            get { return _genre; } //returns the value
            set { _genre = value; } //sets the value
        }

        public bool GetBorrowedStatus()
        {
            return _isBorrowed;
        }

        public void BorrowBook()
        {
            _isBorrowed = true;
        }

        public void ReturnBook()
        {
                _isBorrowed = false;
        }

        public string Title //public property
        {
            get { return _title; } //get method for returning the value
            set //set method for setting the value
            {
                if (value != "")
                    _title = value;
                else
                    Console.WriteLine("Invalid value!");
            }
        }
        public string Author //public property
        {
            get { return _author; } //get method for returning the value
            set //set method for setting the value
            {
                if (value != "")
                    _author = value;
                else
                    Console.WriteLine("Invalid value!");
            }
        }

        public int ReleaseYear  //public property
        {
            get { return _releaseYear; } //get method for returning the value
            set //set method for setting the value
            {
                if (value != 0)
                    _releaseYear = value;
                else
                    Console.WriteLine("Invalid value!");
            }
        }

        public bool CompareBook(Book book)
        {
            if (_title == book._title && _author == book._author)
                return true;

            return false;
        }

        public void PrintInfo()
        {
            if (_title != "" && _title != null)
                Console.Write(_title);
            if (_author != "" && _author != null)
                Console.Write("by " + _author);
            if (_releaseYear != 0)
                Console.Write(" " + _releaseYear);
            Console.WriteLine("");
        }



    }
}
