using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Neko", "myHome", "Meow", 50, 5, 2000);
            Console.WriteLine(cat.Sound);
            Console.ReadKey();
        }
    }
}
