using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (city == "sofia")
            {
                var coffee = 0.50;
                var water = 0.80;
                var beer = 1.20;
                var sweets = 1.45;
                var peanuts = 1.60;
                if (product == "coffee")
                {
                    Console.WriteLine(coffee * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(water * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(beer * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(sweets * quantity);
                }
                else
                {
                    Console.WriteLine(peanuts * quantity);
                }
            }
            else if (city == "plovdiv")
            {
                var coffee = 0.40;
                var water = 0.70;
                var beer = 1.15;
                var sweets = 1.30;
                var peanuts = 1.50;
                if (product == "coffee")
                {
                    Console.WriteLine(coffee * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(water * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(beer * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(sweets * quantity);
                }
                else
                {
                    Console.WriteLine(peanuts * quantity);
                }
            }
            else if (city == "varna")
            {
                var coffee = 0.45;
                var water = 0.70;
                var beer = 1.10;
                var sweets = 1.35;
                var peanuts = 1.55;
                if (product == "coffee")
                {
                    Console.WriteLine(coffee * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(water * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(beer * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(sweets * quantity);
                }
                else
                {
                    Console.WriteLine(peanuts * quantity);
                }
            }
            else
            {
                Console.WriteLine("We dont have that city");
            }
        }
    }
}
