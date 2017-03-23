using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string season = Console.ReadLine();


            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                //Bulgaria
                double price = 0;
                if(season == "summer")
                {
                    price = Math.Round(budget * 0.3, 2);
                    Console.WriteLine("Camp - {0:F2}", price);
                }
                else
                {
                    price = Math.Round(budget * 0.7, 2);
                    Console.WriteLine("Hotel - {0:F2}",price);
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                //Balkans
                double price = 0;
                if (season == "summer")
                {
                    price = Math.Round(budget * 0.4, 2);
                    Console.WriteLine("Camp - {0:F2}", price);
                }
                else
                {
                    price = Math.Round(budget * 0.8, 2);
                    Console.WriteLine("Hotel - {0:F2}", price);
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                //Europe
                double price = Math.Round(budget * 0.9, 2);
                Console.WriteLine("Hotel - {0:F2}", price);

            }
        }
    }
}
