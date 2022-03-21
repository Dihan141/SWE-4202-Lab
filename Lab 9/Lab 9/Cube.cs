using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Cube : Rectangle_Shape
    {
        public Cube(double Length, double Width, double Height)
        {
            length = Length;
            width = Width;
            height = Height;
        }
        public Cube() { }

        public double Volume ()
        {
            double volume = length * width * height;
            return volume;
        }

        public double SurfaceArea()
        {
            double area = 2 * (length * width + width * height + length * height);
            return area;
        }

        public string Whoami()
        {
            return "I am Cuboid. I am three dimensional.";
        }
    }
}
