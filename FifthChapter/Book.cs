using System;

namespace Defining
{
    public class Book
    {
        string _name;
        private bool _booked = false;
        private string _author;

        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public int _pagecount { get; set; }
        
        public override string ToString()
        {
            return $"Name: {_name}; Author: {_author}; PageCount: {_pagecount}";
        }

        public string Author
        {
            get => _author;
            /*
            get {
                return _author;
            }
            */
            set => _author = value;
        }

        public string GetDescription()
        {
            return $"{_name} by {_author}";
        }

        public void Borrow()
        {
            if (!_booked)
            {
                _booked = true;
                return;
            }

            throw new ApplicationException("Already booked!");
        }

        public void Return()
        {
            _booked = false;
        }
    }
}