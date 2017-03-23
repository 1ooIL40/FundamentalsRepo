using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = first + second + third;
            int min = 0;
            
            if (sum > 59)
            {
                min++;
                sum = sum - 60;
            }
            if (sum > 59)
            {
                min++;
                sum = sum - 60;
            }
            if (sum < 10)
            {
                Console.WriteLine(min + ":" + "0" + sum);
            }
            else
            {
                Console.WriteLine(min + ":" + sum);
            }
        }
    }
}
