using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                
                for (int spacess = 0; spacess < num - row; spacess++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 1; i <= row - 1; i++)
                {
                   Console.Write(" *");
                }
                Console.WriteLine();
            }
            //bottom
            for (int row = num - 1; row >= 1; row--)
            {
                
                for (int spacess = 0; spacess < num - row; spacess++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 1; i <= row - 1; i++)
                {
                   Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
