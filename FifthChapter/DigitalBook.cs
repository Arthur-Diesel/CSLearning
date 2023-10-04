using System;

namespace Defining
{
    public class DigitalBook : Book
    {
        // private string _type;
        public DigitalBook(string name, string author, int pagecount /* , string type */ ) : base(name, author, pagecount)
        {
            // _type = type;
        }
    }
}