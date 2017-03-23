using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaOfWineyard = int.Parse(Console.ReadLine());
            double grapes = double.Parse(Console.ReadLine());
            int litersWineNeed = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grapesForWine = 0.4;
            double wineDone = 0;
            double wineForWorkers = 0;
            double wineForGiven = 0;

            wineDone = ((areaOfWineyard * grapes) / 2.5) * grapesForWine;

            if (wineDone >= litersWineNeed)
            {
                wineForGiven = Math.Ceiling(wineDone - litersWineNeed);
                wineForWorkers = Math.Ceiling(wineForGiven / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", (int)wineDone);
                Console.WriteLine("{0} liters left -> {1} liters per person.",wineForGiven,wineForWorkers);
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(litersWineNeed - wineDone));
            }

        }
    }
}
