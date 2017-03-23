using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_OR_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            if (n < 1)
            {
                    Console.WriteLine("OddSum = " + n);
                    Console.WriteLine("OddMin = No");
                    Console.WriteLine("OddMax = No");
                    Console.WriteLine("EvenSum = " + n);
                    Console.WriteLine("EvenMin = No");
                    Console.WriteLine("EvenMax = No");
                
            }
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    oddSum += num;
                    if (oddMax < num)
                    {
                        oddMax = num;
                    }
                    if (oddMin > num)
                    {
                        oddMin = num;
                    }
                }
                else
                {
                    evenSum += num;
                    if (evenMax < num)
                    {
                        evenMax = num;
                    }
                    if (evenMin > num)
                    {
                        evenMin = num;
                    }
                }
            }
            Console.WriteLine("OddSum = "+ oddSum);
            Console.WriteLine("OddMin = " + oddMin);
            Console.WriteLine("OddMax = " + oddMax);

            Console.WriteLine("EvenSum = " + evenSum);
           if (n == 1)
             {
                Console.WriteLine("EvenMin = No");
                Console.WriteLine("EvenMax = No");
             }
             else
             {
                Console.WriteLine("EvenMin = " + evenMin);
                Console.WriteLine("EvenMax = " + evenMax);
            }
        }
    }
}
