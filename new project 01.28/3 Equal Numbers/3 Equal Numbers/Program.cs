using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double one = double.Parse(Console.ReadLine());
            double two = double.Parse(Console.ReadLine());
            double three = double.Parse(Console.ReadLine());
            
            if (one == two && two == three)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
