using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            int addPositions = n;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumOdd += num;
                }
                if (!(i % 2 == 0))
                {
                    sumEven += num;
                }
            }
            if(sumOdd == sumEven)
            {
                Console.WriteLine("Yes Sum = " +sumOdd);
            }
            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(sumOdd-sumEven));
            }
        }
    }
}
