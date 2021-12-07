using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something
{
    internal class Article: Book
    {
        public string doi, publishDate, cj;

        public string getInfo()
        {
            string s = id + "\t" + title + "\t" + author + "\t" + doi + "\t" + quantity.ToString() + "\t" + cj;
            return s;
        }
    }
}
