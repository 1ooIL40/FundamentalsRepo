using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double one = double.Parse(Console.ReadLine());
            double two = double.Parse(Console.ReadLine());
            double tree = double.Parse(Console.ReadLine());
            double four = double.Parse(Console.ReadLine());
            double five = double.Parse(Console.ReadLine());
            double six = double.Parse(Console.ReadLine());
            double seven = double.Parse(Console.ReadLine());


            double areaFloor = two * tree;
            double areaPlate = four * (five / 2);
            double plateNeedet = Math.Ceiling(areaFloor / areaPlate) + 5;
            double sum = plateNeedet * six + seven;

            if (sum <= one)
            {
                Console.WriteLine("{0:f2} lv left.",one - sum);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", sum - one);
            }
        }
    }
}
