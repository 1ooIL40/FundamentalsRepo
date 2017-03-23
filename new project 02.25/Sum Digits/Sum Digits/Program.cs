using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;

            while (num > 0)
            {
                number = num % 10;
                num /= 10;
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
