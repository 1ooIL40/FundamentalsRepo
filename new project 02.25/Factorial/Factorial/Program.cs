using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int fact = num;

            for (int i = num; i > 1; i--)
            {
                num -= 1;
                fact *= num;
            }
            Console.WriteLine(fact);

        }
    }
}
