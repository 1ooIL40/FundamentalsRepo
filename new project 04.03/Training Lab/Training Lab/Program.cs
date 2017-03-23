using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double wCentimeters = w * 100;
            double hCentimeters = h * 100;

            hCentimeters = hCentimeters - 100;

            int deskPerRow = (int) hCentimeters / 70;
            int rows = (int) wCentimeters / 120;
            int totalSeats = deskPerRow * rows - 3;

            Console.WriteLine(totalSeats);
        }
    }
}
