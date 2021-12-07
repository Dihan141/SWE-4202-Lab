using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something
{
    internal class User
    {
        string id, name, address, bookId;
        public List<Book> bBooks = new List<Book>();

        public string getId()
        {
            return id;
        }
        public void setId(string  id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getBookId()
        {
            return bookId;
        }
        public void setBookId(string bookId)
        {
            this.bookId = bookId;
        }
    }
}
