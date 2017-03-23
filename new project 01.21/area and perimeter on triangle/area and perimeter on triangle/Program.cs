using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_and_perimeter_on_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var pi = Math.PI;
            var Area = r * pi * r;
            var Perimeter = 2 * pi * r;
            Console.WriteLine("Area = " + Area + "\n" + "Perimeter = " + Perimeter);
        }
    }
}
