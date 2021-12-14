using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_management_system
{
    internal class Medicine
    {
        public string name;
        public int price;
        private int amount;
        private string id;

        public int getAmount()
        {
            return amount;
        }
        public void setAmount(int amount)
        {
            this.amount = amount;
        }

        public string getId()
        {
            return id;
        }
        public void setId(string id)
        {
            this.id = id;
        }

        public string getInfo()
        {
            string s = name + "\t" + id + "\t" + amount + "\t" + price;
            return s;
        }
    }
}
