using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = 2 * (n - 2) + 1;
            int rowNumbers = n - 2;

            string asteriks = "*";
            string dash = "/";
            string reversedDash = "\\";
            string minus = "-";
            string monkeyA = "@";
            string spacess = " ";

            //Console.WriteLine(height);
            //Console.WriteLine(width);


            for (int colmn = 0; colmn < rowNumbers; colmn++)
            {
                for (int row = 0; row < rowNumbers; row++)
                {
                    if (colmn % 2 == 1)
                    {
                        Console.Write(minus);
                    }
                    else if (colmn % 2 == 0)
                    {
                        Console.Write(asteriks);
                    }
                }
                Console.Write(reversedDash);
                Console.Write(spacess);
                Console.Write(dash);
                for (int row = 0; row < rowNumbers; row++)
                {
                    if (colmn % 2 == 1)
                    {
                        Console.Write(minus);
                    }
                    else if (colmn % 2 == 0)
                    {
                        Console.Write(asteriks);
                    }
                }



                Console.WriteLine();
            }
            for (int space = 0; space <= rowNumbers; space++)
            {
                Console.Write(spacess);
            }
            Console.Write(monkeyA);

            for (int space = 0; space <= rowNumbers ; space++)
            {
                Console.Write(spacess);
            }

            Console.WriteLine();


            for (int colmn = 0; colmn < rowNumbers; colmn++)
            {
                for (int row = 0; row < rowNumbers; row++)
                {
                    if (colmn % 2 == 1)
                    {
                        Console.Write(minus);
                    }
                    else if (colmn % 2 == 0)
                    {
                        Console.Write(asteriks);
                    }
                }
                Console.Write(dash);
                Console.Write(spacess);
                Console.Write(reversedDash);
                for (int row = 0; row < rowNumbers; row++)
                {
                    if (colmn % 2 == 1)
                    {
                        Console.Write(minus);
                    }
                    else if (colmn % 2 == 0)
                    {
                        Console.Write(asteriks);
                    }
                }



                Console.WriteLine();
            }

        }
    }
}
