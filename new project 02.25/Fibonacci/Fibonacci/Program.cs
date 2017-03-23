using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            int sumF = 0;

            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    sumF = f0 + f1;
                    f0 = f1;
                    f1 = sumF;
                }
                Console.WriteLine(sumF);
            }


        }
    }
}
