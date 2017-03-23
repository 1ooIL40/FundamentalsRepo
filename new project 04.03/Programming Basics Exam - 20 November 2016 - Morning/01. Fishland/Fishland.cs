using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            double kgSk = double.Parse(Console.ReadLine()); // lv
            double kgC = double.Parse(Console.ReadLine()); //lv

            double kgP = double.Parse(Console.ReadLine()); //kg
            double kgSf = double.Parse(Console.ReadLine()); //kg
            int kgM = int.Parse(Console.ReadLine());
            double bill = 0;

            double priceOfP = kgP * (kgSk + (kgSk * 0.60));
            double priceOfSf = kgSf * (kgC + (kgC * 0.80));
            double priceOfM = kgM * 7.50;

            bill = priceOfM + priceOfP + priceOfSf;

            Console.WriteLine("{0:f2}",bill);

        }
    }
}
