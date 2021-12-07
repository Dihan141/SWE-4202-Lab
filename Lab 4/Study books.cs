using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something
{
    internal class Study_books: Book
    {
        public string isbn, genre;

        public string getInfo()
        {
            string s = id + "\t" + title + "\t" + author + "\t" + isbn + "\t" + Convert.ToString(quantity);
            return s;
        }
    }
}
