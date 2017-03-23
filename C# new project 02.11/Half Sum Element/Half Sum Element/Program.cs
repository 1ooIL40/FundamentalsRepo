using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;
            int sum = 0;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(maxValue < num)
                {
                    maxValue = num;
                }
                sum += num;
            }
            sum -= maxValue;

            if (sum == maxValue)
            {
                result = sum;
                Console.WriteLine("Yes sum = " + result);
            }
            else
            {
                result = Math.Abs(sum - maxValue);
                Console.WriteLine("No Diff = " + result);
            }
        }
    }
}
