using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write("*");
                for (int j = 1; j < num; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
