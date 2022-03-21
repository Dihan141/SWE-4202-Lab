using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    internal class Sphere : Round_Shape
    {
        public Sphere(double radius)
        {
            Radius = radius;
        }

        public Sphere()
        {

        }
        public double Volume()
        {
            double volume = (4 / 3) * 3.1416 * Radius * Radius * Radius;
            return volume;
        }

        public double SurfaceArea()
        {
            double area = 4 * 3.1416 * Radius * Radius;
            return area;
        }

        public string Whoami()
        {
            return "I am Sphere. I am three dimensional";
        }
    }
}
