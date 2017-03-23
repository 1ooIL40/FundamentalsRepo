using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double secondnumber = double.Parse(Console.ReadLine());
            if (number >= secondnumber)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(secondnumber);
            }
        }
    }
}
