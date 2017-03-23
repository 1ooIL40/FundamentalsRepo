using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            //magnolias 3.25; syumbyul 4; roses 3.50; cactuses 8; lv

            int numberMagnolias = int.Parse(Console.ReadLine());
            int numberSymbyuls = int.Parse(Console.ReadLine());
            int numberRoses = int.Parse(Console.ReadLine());
            int numberCactuses = int.Parse(Console.ReadLine());

            double giftPrice = double.Parse(Console.ReadLine());
            double sum = 0;
            double taxes = 0;

            sum = numberMagnolias * 3.25 + numberSymbyuls * 4 + numberRoses * 3.50 + numberCactuses * 8;
            taxes = sum - (sum * 0.05);
            
            if (giftPrice > taxes)
            {
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling(giftPrice - taxes));
            }
            else
            {
                Console.WriteLine("She is left with {0} leva.",Math.Floor(taxes - giftPrice));
            }


        }
    }
}
