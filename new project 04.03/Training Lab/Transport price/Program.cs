using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_price
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string timePeriod = Console.ReadLine();

            if (kilometers > 100)
            {
                //train
                double price = 0;
                if (timePeriod == "day")
                {
                    price = kilometers * 0.06;
                    Console.WriteLine(price);
                }
            }
            else if (kilometers >=20 && kilometers < 100)
            {
                //buss
                double price = 0;
                price = kilometers * 0.09;
                Console.WriteLine(price);
            }
            else
            {
                //taxi
                double price = 0;
                if(timePeriod == "day")
                {
                    price = kilometers * 0.79 + 0.7;
                }
                else
                {
                    price = kilometers * 0.9 + 0.7;
                }
            }
        }
    }
}
