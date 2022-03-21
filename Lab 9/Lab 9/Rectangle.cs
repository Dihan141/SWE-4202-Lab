using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Rectangle : Rectangle_Shape
    {
        public Rectangle(double Length, double Width)
        {
            length = Length;
            width = Width;
        }
        public Rectangle() { }
        public double Area()
        {
            double area = length * width;
            return area;
        }

        public double Perimeter()
        {
            double perimeter = 2 * (length + width);
            return perimeter;
        }

        public string WhoamI()
        {
            return "I am Rectangle. I am two dimensional";
        }
    }
}
