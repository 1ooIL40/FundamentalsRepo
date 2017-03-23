using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortress
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fortColm = n / 2;
            int midSize = n * 2 - 4 - 2 * (n / 2);
            int width = 2 * n -2;

            string dash = "/";
            string reversedDash = "\\";
            string xor = "^";
            string underscore = "_";
            string verticalLine = "|";
            string spacess = " ";

            Console.WriteLine(midSize);
            

            for (int fortres = 0; fortres < n; fortres++)
            {
                //First row
                if (fortres == 0)
                {
                    Console.Write(dash);
                     
                    for (int size = 0; size < fortColm; size++)
                    {
                        Console.Write(xor);
                    }
                    Console.Write(reversedDash);
                    if (n > 4)
                    {
                        for (int size = 0; size < midSize; size++)
                        {
                            Console.Write(underscore);
                        }
                    }
                    Console.Write(dash);
                    for (int size = 0; size < fortColm; size++)
                    {
                        Console.Write(xor);
                    }
                    Console.Write(reversedDash);
                }
                Console.WriteLine();
                //Body row
                if (fortres < n-3)
                {
                    Console.Write(verticalLine);
                    if (n > 4)
                    {
                        for (int size = 0; size < width; size++)
                        {
                            Console.Write(spacess);
                        }
                    }
                    else
                    {
                        for (int size = 0; size < width; size++)
                        {
                            Console.Write(spacess);
                        }
                    }
                    Console.Write(verticalLine);
                }
                //Body lastr row
                if(fortres == n - 3)
                {
                    Console.Write(verticalLine);
                    for (int size = 0; size < fortColm +1; size++)
                    {
                        Console.Write(spacess);
                    }
                    if (n > 4)
                    {
                        for (int size = 0; size < midSize; size++)
                        {
                            Console.Write(underscore);
                        }
                    }
                    for (int size = 0; size < fortColm + 1; size++)
                    {
                        Console.Write(spacess);
                    }
                    Console.Write(verticalLine);
                }
                //Last row
                if(fortres == n-2)
                {
                    Console.Write(reversedDash);
                    for (int size = 0; size < fortColm; size++)
                    {
                        Console.Write(underscore);
                    }
                    Console.Write(dash);
                    if (n > 4)
                    {
                        for (int size = 0; size < midSize; size++)
                        {
                            Console.Write(spacess);
                        }
                    }
                    Console.Write(reversedDash);
                    for (int size = 0; size < fortColm; size++)
                    {
                        Console.Write(underscore);
                    }
                    Console.Write(dash);
                }
            }
        }
    }
}
