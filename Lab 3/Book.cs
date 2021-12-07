using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something
{
    internal class Book
    {
        int quantity;
        string id, name, author, publisher;
        
        public string getId()
        {
            return id;
        }
        public void setId(string id)
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

        public string getAuthor()
        {
            return author;
        }
        public void setAuthor(string author)
        {
            this.author = author;
        }

        public string getPublisher()
        {
            return publisher;
        }
        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public int getQuantity()
        {
            return quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
