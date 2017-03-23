using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonuspoint = 0.0;
            double sum = 0.0;
            if (number < 100)
            {
                bonuspoint = 5;
                if (number % 2 == 0)
                {
                    sum = 1 + bonuspoint;
                    Console.WriteLine(sum);
                    Console.WriteLine(number + sum);
                }
                else if (number % 5 == 0)
                {
                    sum = 2 + bonuspoint;
                    Console.WriteLine(sum);
                    Console.WriteLine(number + sum);
                }
                else
                {
                    Console.WriteLine(bonuspoint);
                    Console.WriteLine(number + bonuspoint);
                }
            }
             else if (number < 1000)
            {
                bonuspoint = number * 0.20;
                if (number % 2 == 0)
                {
                    sum = 1 + bonuspoint;
                    Console.WriteLine(sum);
                    Console.WriteLine(number + sum);
                }
                else if (number % 5 == 0)
                {
                    sum = 2 + bonuspoint;
                    Console.WriteLine(sum);
                    Console.WriteLine(number + sum);
                }
                else
                {
                    Console.WriteLine(bonuspoint);
                    Console.WriteLine(number + bonuspoint);
                }
            }
            else
            {
                bonuspoint = number * 0.10;
                if (number % 2 == 0)
                {
                    sum = 1 + bonuspoint;
                    Console.WriteLine(sum);
                    Console.WriteLine(number + sum);
                }
                else if (number % 5 == 0)
                {
                    sum = 2 + bonuspoint;
                    Console.WriteLine(sum);
                    Console.WriteLine(number + sum);
                }
                else
                {
                    Console.WriteLine(bonuspoint);
                    Console.WriteLine(number + bonuspoint);
                }
            }
        }
    }
}
