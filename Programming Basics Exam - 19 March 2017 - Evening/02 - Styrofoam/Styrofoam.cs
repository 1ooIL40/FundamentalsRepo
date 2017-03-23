using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double areaOfHouse = double.Parse(Console.ReadLine());
            double number = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double priceOfOne = double.Parse(Console.ReadLine());
            double result = 0;


            double area = areaOfHouse - (number * 2.4);
            double realArea = area + (area * 0.1);
            double needetPackages = Math.Ceiling(realArea / meters) * priceOfOne; 

            if (needetPackages <= budget)
            {
                result = budget - needetPackages;
                Console.WriteLine("Spent: {0:f2}", needetPackages);
                Console.WriteLine("Left: {0:f2}",result);
            }
            else
            {
                result = needetPackages - budget;
                Console.WriteLine("Need more: {0:f2}", result);
            }
        }
    }
}
