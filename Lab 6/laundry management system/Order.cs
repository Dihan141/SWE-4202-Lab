using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laundry_management_system
{
    internal class Order
    {
        public string status, orderId;
        public int shirt, pant, suit, sheet, shirtPrice, pantPrice, suitPrice, sheetPrice;
        public string shirttodo, panttodo, suittodo, sheettodo;

        public string getShirtInfo()
        {
            string s = "Shirt\t" + shirt + "\t" + shirttodo + "\t" + shirtPrice * shirt;
            return s;
        }
        public string getPantInfo()
        {
            string s = "Pant\t" + pant + "\t" + panttodo + "\t" + pantPrice * pant;
            return s;
        }
        public string getSuitInfo()
        {
            string s = "Suit\t" + suit + "\t" + suittodo + "\t" + suitPrice * suit;
            return s;
        }
        public string getSheetInfo()
        {
            string s = "Sheet\t" + sheet + "\t" + sheettodo + "\t" + sheetPrice * sheet;
            return s;
        }
        public string getAmount()
        {
            string s = ((pantPrice*pant) + (suitPrice*suit) + (sheetPrice*sheet) + (shirtPrice*shirt)).ToString();
            return s;
        }
    }
}
