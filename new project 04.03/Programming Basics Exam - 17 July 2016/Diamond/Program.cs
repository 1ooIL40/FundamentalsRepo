using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 5 * n;
            int height = 3 * n + 2;
            int bot = height - n + 1;
            int count = 0;
            int lastRow = (width - (n - 2)) /2;

            string dot = ".";
            string asteriks = "*";

            var first = DateTime.Now;

            //Console.WriteLine(width);
            //Console.WriteLine(height);
            //Console.WriteLine(lastRow);

            //first row
            for (int colms = 0; colms < 1; colms++)
            {
                for (int row = 0; row < 1; row++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(dot);
                    }
                    for (int i = n; i < width - n; i++)
                    {
                        Console.Write(asteriks);
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(dot);
                    }
                }
                Console.WriteLine();
            }
            //second rows to the middle
            for (int colms = 1; colms < n; colms++)
            {
                for (int rows = colms; rows < n; rows++)
                {
                    Console.Write(dot);
                }
                Console.Write(asteriks);
                for (int mid = 0; mid < width - 2*n + count; mid++)
                {
                    Console.Write(dot);
                }
                count+=2;
                Console.Write(asteriks);
                for (int rows = colms; rows < n; rows++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
            }
            //middle
            for (int mid = 0; mid < 1; mid++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write(asteriks);
                }
            }
            Console.WriteLine();
            //bottom rows
            for (int colms = 1; colms < bot-2; colms++)
            {
                for (int row = 0; row < colms ; row++)
                {
                    Console.Write(dot);
                }
                Console.Write(asteriks);
                count -= 2;
                for (int mid = 0; mid < width - 2*n + count; mid++)
                {
                    Console.Write(dot);
                }
                Console.Write(asteriks);
                for (int row = 0; row < colms; row++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
            }
            //last row

            for (int row = 0; row < 1; row++)
            {
                for (int i = 0; i < lastRow; i++)
                {
                    Console.Write(dot);
                }
                for (int i = 0; i < n-2; i++)
                {
                    Console.Write(asteriks);
                }
                for (int i = 0; i < lastRow; i++)
                {
                    Console.Write(dot);
                }

            }
            Console.WriteLine();

            var second = DateTime.Now;

           Console.WriteLine(second - first); //00:16:22.3181854 for n = 1000
        }
    }
}
