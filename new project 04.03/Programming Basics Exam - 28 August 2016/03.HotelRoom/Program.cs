using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int days = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;

            // May, June, July, August, September или October

            if (month == "may" || month == "october")
            {
                studio = 50;
                apartment = 65;
                if (days > 7 && days < 15)
                {
                    studio -= (studio * 0.05);

                    Console.WriteLine("Apartment: {0:f2} lv.", apartment * days);
                    Console.WriteLine("Studio: {0:f2} lv.", studio * days);
                }
                else if (days > 14)
                {
                    studio -= (studio * 0.3);
                    apartment -= (apartment * 0.1);

                    Console.WriteLine("Apartment: {0:f2} lv.", apartment * days);
                    Console.WriteLine("Studio: {0:f2} lv.", studio * days);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment * days);
                    Console.WriteLine("Studio: {0:f2} lv.", studio * days);
                }
            }
            else if (month == "june" || month == "september")
            {
                studio = 75.20;
                apartment = 68.70;
                if (days > 14)
                {
                    studio -= (studio * 0.2);
                    apartment -= (apartment * 0.1);

                    Console.WriteLine("Apartment: {0:f2} lv.", apartment * days);
                    Console.WriteLine("Studio: {0:f2} lv.", studio * days);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment * days);
                    Console.WriteLine("Studio: {0:f2} lv.", studio * days);
                }

            }
            else if (month == "july" || month == "august")
            {
                studio = 76;
                apartment = 77;
                if (days > 14)
                {
                    apartment -= (apartment * 0.1);

                    Console.WriteLine("Apartment: {0:f2} lv.", apartment * days);
                    Console.WriteLine("Studio: {0:f2} lv.", studio * days);
                }
                else
                {
                    Console.WriteLine("Apartment: {0:f2} lv.", apartment * days);
                    Console.WriteLine("Studio: {0:f2} lv.", studio * days);
                }
            }
        }
    }
}
