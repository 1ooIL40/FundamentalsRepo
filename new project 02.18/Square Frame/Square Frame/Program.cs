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
            int n = int.Parse(Console.ReadLine());
            int bodyCount = n - 2;

            for (int i = 0; i < n * 2 - 1; i++)
            {
                if (i == 0 || i == n * 2 - 2)
                {
                    Console.Write("+");
                }
                else if (!(i % 2 == 0))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
            //mid
            for (int j = 0; j < n - 2; j++)
            {

                for (int i = 0; i < n * 2 - 1; i++)
                {
                    if (i == 0 || i == n * 2 - 2)
                    {
                        Console.Write("|");
                    }
                    else if (!(i % 2 == 0))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n * 2 - 1; i++)
            {
                if (i == 0 || i == n * 2 - 2)
                {
                    Console.Write("+");
                }
                else if (!(i % 2 == 0))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }
    }
}
