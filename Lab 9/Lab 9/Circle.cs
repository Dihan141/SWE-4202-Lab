using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Circle : Round_Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public Circle()
        {

        }
        public double Area()
        {
            double area = 3.1416 * Radius * Radius;
            return area;
        }

        public double Perimeter()
        {
            double perimeter = 2 * 3.1416 * Radius;
            return perimeter;
        }

        public string Whoami()
        {
            return "I am Circle. I am two dimensional";
        }
    }
}
