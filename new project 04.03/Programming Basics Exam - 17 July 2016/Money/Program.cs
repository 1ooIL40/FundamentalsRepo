using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBitcoin = int.Parse(Console.ReadLine());
            double numberOfIoans = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double result = 0;
            double commisionPercent = commision / 100;

            double lvInEuro = 1.95;
            double bitcoinInLv = numberOfBitcoin * 1168;
            double ioansInLv = (numberOfIoans * 0.15) * 1.76;

            result = (bitcoinInLv + ioansInLv) / lvInEuro; 

            Console.WriteLine(result - (commisionPercent * result));
        }
    }
}
