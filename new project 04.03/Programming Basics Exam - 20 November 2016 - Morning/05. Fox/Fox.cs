using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int width = 2 * number + 3;
            int middle = number / 3;
            int midFull = number / 2;
            int count = 0;
            int midCount = 0;
                
            string asteriks = "*";
            string minus = "-";
            string dash = "/";
            string revDash = "\\";
            string verticalLine = "|";

                //Console.WriteLine(width);
                //Console.WriteLine(middle);

                // Top Part
                for (int row = 1; row <= number; row++)
                {
                    for (int colm =0 ; colm < row ; colm++)
                    {
                        Console.Write(asteriks);
                    }
                    Console.Write(revDash);

                    for (int mid = 0; mid < width - 4 - count; mid++)
                    {
                        Console.Write(minus);
                    }
                    count += 2;
                    Console.Write(dash);
                    for (int colm = 0; colm < row; colm++)
                    {
                        Console.Write(asteriks);
                    }
                    Console.WriteLine();
                }
                count = 0;

                // Middle part 
                for (int row = 1; row <= middle; row++)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write(verticalLine);
                    }

                    for (int i = 1; i <= midFull + count; i++)
                    {
                        Console.Write(asteriks);
                    }
                    Console.Write(revDash);

                    for (int i = 0; i < number - midCount; i++)
                    {
                        Console.Write(asteriks);
                    }
                    midCount += 2;
                    Console.Write(dash);
                    for (int i = 1; i <= midFull + count; i++)
                    {
                        Console.Write(asteriks);
                    }
                    count++;
                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write(verticalLine);
                    }
                    Console.WriteLine();
                }
                count = 0;
                // Bottom Part
                for (int row = 1; row <= number; row++)
                {
                    for (int colm = 0; colm < row; colm++)
                    {
                        Console.Write(minus);
                    }
                    Console.Write(revDash);

                    for (int mid = 0; mid < width - 4 - count; mid++)
                    {
                        Console.Write(asteriks);
                    }
                    count += 2;
                    Console.Write(dash);
                    for (int colm = 0; colm < row; colm++)
                    {
                        Console.Write(minus);
                    }
                    Console.WriteLine();
                }
        }
    }
}
