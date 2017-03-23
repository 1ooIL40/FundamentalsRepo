using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            if (number >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
