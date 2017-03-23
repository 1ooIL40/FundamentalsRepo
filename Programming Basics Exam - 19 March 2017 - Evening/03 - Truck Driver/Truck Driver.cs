using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Spring", "Summer", "Autumn" или "Winter"
            string season = Console.ReadLine().ToLower();
            double kilometers = double.Parse(Console.ReadLine());

            double s = 0;
            double w = 0;
            double sA = 0;
            double oneSeason = 0;
            double result = 0;

            if (kilometers <= 5000)
            {
                s = 0.90;
                w = 1.05;
                sA = 0.75;
            }
            else if (kilometers <= 10000)
            {
                s = 1.10;
                w = 1.25;
                sA = 0.95;
            }
            else if (kilometers <= 20000)
            {
                s = 1.45;
                w = 1.45;
                sA = 1.45;
            }

            if (season == "summer")
            {
                oneSeason = (kilometers * s) * 4;
                result = oneSeason - (oneSeason * 0.1);
            }
            else if (season == "winter")
            {
                oneSeason = (kilometers * w) * 4;
                result = oneSeason - (oneSeason * 0.1);
            }
            else if (season == "spring" || season == "autumn")
            {
                oneSeason = (kilometers * sA) * 4;
                result = oneSeason - (oneSeason * 0.1);
            }
            Console.WriteLine("{0:f2}",result);
        }
    }
}
