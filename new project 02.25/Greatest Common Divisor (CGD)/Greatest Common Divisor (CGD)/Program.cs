using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;
            try
            {
                while (a > b)
                {
                    a %= b;
                    if(a == 0)
                    {
                        Console.WriteLine(b);
                    }
                }
                while(b == 0 || a ==b)
                {
                    Console.WriteLine(a);
                    break;
                }
                while (a < b)
                {
                    c = a;
                    a = b;
                    b = c;
                    a %= b;
                    if (a == 0)
                    {
                        Console.WriteLine(b);
                    }
                }
            }
            catch (DivideByZeroException)
            {

            }

        }
    }
}
