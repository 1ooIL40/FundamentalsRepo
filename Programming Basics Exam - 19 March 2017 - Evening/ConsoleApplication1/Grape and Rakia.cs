using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            double unussalbe = double.Parse(Console.ReadLine());

            double grapeKg = area * kg;
            double ussable = grapeKg - unussalbe;

            double rakia = ussable * 0.45;
            double litres = rakia / 7.5;
            double income = litres * 9.80;

            double sell = ussable * 0.55;
            double grapeIncome = sell * 1.5;

            Console.WriteLine("{0:f2}",income);
            Console.WriteLine("{0:f2}",grapeIncome);
        }
    }
}
