using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfYear = Console.ReadLine().ToLower();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double weekendInSofia = 48-h;
            double saturdayGames = 0;
            double holidayGames = 0;
            double leapYear = 0;
            double result = 0;

            saturdayGames = weekendInSofia * 3 / 4;
            holidayGames = p * 2 / 3;

            switch (typeOfYear)
            {
                case "leap":
                    leapYear = (saturdayGames + holidayGames + h) * 0.15;
                    result = (saturdayGames + holidayGames + h + leapYear);
                    Console.WriteLine(Math.Floor(result));
                    break;
                case "normal":
                    result = (saturdayGames + holidayGames + h);
                    Console.WriteLine(Math.Floor(result));
                    break;
                default:
                    break;
            }

            //Console.WriteLine(holidayGames);
            //Console.WriteLine(saturdayPlay);
            //Console.WriteLine(weekendInSofia);
        }
    }
}
