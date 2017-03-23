using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }

            result = Math.Abs(leftSum - rightSum);
            
            if(result == 0)
            {
                Console.WriteLine("Yes sum " + leftSum);
            }
            else
            {
                Console.WriteLine("No diff " + result);
            }
            
        }
    }
}
