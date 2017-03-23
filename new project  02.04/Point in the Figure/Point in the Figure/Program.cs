using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = 0;
            int x2 = 3*h;
            int y2 = h;
            int x3 = h;
            int y3 = 0;
            int x4 = 2*h;
            int y4 = 4*h;


            if (((x >= x1 && x <= x2) && (y >= y1 && y <= y2)) || ((x >= x3 && x <= x4) && (y >= y3 && y <= y4)))
            {
                if (((x > x1 && x < x2) && (y > y1 && y < y2)) || ((x > x3 && x < x4) && (y > y3 && y < y4)))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("border");
                }
            }
            else 
            {
                Console.WriteLine("outside");
            }

        }
    }
}
