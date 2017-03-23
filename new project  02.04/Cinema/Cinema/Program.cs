using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int columm = int.Parse(Console.ReadLine());
            double result = 0;

            if (type == "premiere")
            {
                result = row * columm * 12.00;
                Console.WriteLine("{0:f2}",result);
            }
            else if (type == "normal")
            {
                result = row * columm * 7.50;
                Console.WriteLine("{0:f2}",result);
            }
            else if (type == "discount")
            {
                result = row * columm * 5.00;
                Console.WriteLine("{0:f2}",result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
