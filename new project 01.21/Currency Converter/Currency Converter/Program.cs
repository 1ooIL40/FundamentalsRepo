using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double convUSD = 1.79549;
            double convEUR = 1.95583;
            double convGBP = 2.53405;
            var number = double.Parse(Console.ReadLine());
            string valute1 = Console.ReadLine();
            string valute2 = Console.ReadLine();
            // Console.WriteLine("{0} {1}" ,valute1,valute2);
            if (valute1 == "BGN")
            {
                if (valute2 == "USD")
                {
                    Console.WriteLine(Math.Round(number / convUSD, 2));
                }
                if (valute2 == "EUR")
                {
                    Console.WriteLine(Math.Round(number / convEUR, 2));
                }
                if (valute2 == "GBP")
                    Console.WriteLine(Math.Round(number / convGBP, 2));
            }
            else if (valute1 == "USD")
            {
                if (valute2 == "BGN")
                {
                    Console.WriteLine(Math.Round(number * convUSD, 2));
                }
                if (valute2 == "EUR")
                {
                    Console.WriteLine(Math.Round((number * convUSD) / convEUR, 2));
                }
                if (valute2 == "GBP")
                {
                    Console.WriteLine(Math.Round((number * convUSD) / convGBP, 2));
                }
            }
            else if (valute1 == "EUR")
            {
                if (valute2 == "BGN")
                {
                    Console.WriteLine(Math.Round(number * convEUR, 2));
                }
                if (valute2 == "USD")
                {
                    Console.WriteLine(Math.Round((number * convEUR) * convUSD, 2));
                }
                if (valute2 == "GBP")
                {
                    Console.WriteLine(Math.Round((number * convEUR) / convGBP, 2));
                }
            }
            else if (valute1 == "GBP")
            {
                if (valute2 == "BGN")
                {
                    Console.WriteLine(Math.Round(number / convGBP, 2));
                }
                if (valute2 == "USD")
                {
                    Console.WriteLine(Math.Round((number * convGBP) / convUSD, 2));
                }
                if (valute2 == "EUR")
                {
                    Console.WriteLine(Math.Round((number * convGBP) * convEUR, 2));
                }
            }
        }
    }
}
