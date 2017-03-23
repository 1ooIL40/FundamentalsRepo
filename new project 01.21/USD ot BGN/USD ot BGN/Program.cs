using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_ot_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = double.Parse(Console.ReadLine());
            double convert = 1.79549;
            double BGN = USD * convert;
            Console.WriteLine(Math.Round(BGN,2));
        }
    }
}
