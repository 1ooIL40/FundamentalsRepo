using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int numberOfCargos = int.Parse(Console.ReadLine());
            int tones = 0;
            int sum = 0;
            int van = 0;
            int truck = 0;
            int train = 0;

            double priceWithVan = 0;
            double priceWithTruck = 0;
            double priceWithTrain = 0;
            double haflSumOnTone = 0;

            for (int Cargo = 1; Cargo <= numberOfCargos; Cargo++)
            {
                tones = int.Parse(Console.ReadLine());
                sum += tones;
                if(tones <= 3)
                {
                    van = tones;
                    priceWithVan += van;
                }
                else if (tones <= 11)
                {
                    truck = tones;
                    priceWithTruck += truck;
                }
                else
                {
                    train = tones;
                    priceWithTrain += train;
                }

            }
            haflSumOnTone = (priceWithVan * 200 + priceWithTruck * 175 + priceWithTrain * 120) / sum;
            Console.WriteLine("{0:f2}",haflSumOnTone);
            Console.WriteLine("{0:f2}%",(priceWithVan / sum) * 100);
            Console.WriteLine("{0:f2}%",(priceWithTruck / sum) * 100);
            Console.WriteLine("{0:f2}%",(priceWithTrain / sum) * 100);

        }
    }
}
