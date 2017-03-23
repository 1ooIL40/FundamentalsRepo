using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(num);
            int divider = (int)sqrt;
            int result = 0;

            bool isPrime = true;

            if (num > 1)
            {
                for (int i = 2; i <= divider; i++)
                {
                    result = num % i;
                    if (result == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
