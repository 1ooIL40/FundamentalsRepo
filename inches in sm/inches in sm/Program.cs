using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inches_in_sm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            var convert = inches * 2.54;
            Console.Write("Cantimeter = " + convert + "\n");
        }
    }
}
