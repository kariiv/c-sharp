using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum BookGenre { Horror, ScienceFiction, Romance, Drama }

    class Book
    {
        private string _title; //private field
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
            get { return  _title ; } //get method for returning the value
            set //set method for setting the value
            {
                if (value != "") 
                {
                    _title = value;
                }
                else
                    {
                    Console.WriteLine("Invalid value!");
                }
            }
        }       
    }
}
