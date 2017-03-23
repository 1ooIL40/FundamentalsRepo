using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double secondNum = n * 4 - 4;
            double num = 0;
            num = secondNum/ 2;
            //num = Math.Round((n/secondNum),MidpointRounding.AwayFromZero);
            Console.WriteLine(secondNum);
            Console.WriteLine(num);
        }
    }
}
