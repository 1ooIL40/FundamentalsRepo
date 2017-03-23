using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string spacess = " ";
            string asteriks = "*";

            //Right Part
            for (int i = 0; i <= n; i++)
            {

                for (int j = i; j < n; j++)
                {
                    Console.Write(spacess);
                }
                for (int k = n; k > n-i ; k--)
                {
                    Console.Write(asteriks);
                }
                Console.Write(" | ");
                //Left Part
                for (int k = n; k > n-i; k--)
                {
                    Console.Write(asteriks);
                }
                for (int j = i; j < n; j++)
                {
                    Console.Write(spacess);
                }
                Console.WriteLine();
            }

        }
    }
}
