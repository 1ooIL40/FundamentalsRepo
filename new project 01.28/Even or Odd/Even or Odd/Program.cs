using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            double calculation = number % 2;
            if (calculation == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
