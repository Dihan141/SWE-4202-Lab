using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec1 = new Rectangle(2, 5);
            Console.WriteLine(rec1.Area());
            Console.WriteLine(rec1.Perimeter());
            Cube c1 = new Cube(2, 5, 6);
            Console.WriteLine(c1.SurfaceArea());
            Console.WriteLine(c1.Volume());
            Console.ReadKey();
        }
    }
}
