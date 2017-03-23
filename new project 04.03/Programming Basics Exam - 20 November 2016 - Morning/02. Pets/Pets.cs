using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine()); // kg
            double dogFood = double.Parse(Console.ReadLine()); //kg for day
            double catFood = double.Parse(Console.ReadLine()); //kg for day
            double turtleFood = double.Parse(Console.ReadLine()); //g for day

            double dogNeed = days * dogFood;
            double catNeed = days * catFood;
            double turtleNeed = (days * turtleFood) / 1000;

            double allTheFood = dogNeed + catNeed + turtleNeed;


            if(food >= allTheFood)
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor(food - allTheFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(allTheFood - food));
            }

        }
    }
}
