using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * 57.29578;
            Console.WriteLine(Math.Round(deg));
        }
    }
}
