using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 3 * n;
            int body = 2 * n;
            int engine = n / 2;
            int top = width / 2 - 1;
            int count = 0;
            int dotCount = 0;

            char dot = '.';
            char asteriks = '*';
            char dash = '/';
            char revDash = '\\';
            char spacess = ' ';
            char verLine = '|';


            //Top part
            for (int first = 0; first < n; first++)
            {
                for (int dots = 0; dots < top - dotCount; dots++)
                {
                    Console.Write(dot);
                }
                Console.Write(dash);
                for (int mid = 0; mid < 1 + count; mid++)
                {
                    if (mid > 0)
                    {
                        Console.Write(spacess);
                    }
                }
                Console.Write(revDash);
                for (int dots = 0; dots < top - dotCount; dots++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
                dotCount += 1;
                count += 2;
            }
            count = 0;
            //mid diff row
            for (int midRow = 0; midRow < 1; midRow++)
            {
                for (int i = 0; i < n/2; i++)
                {
                    Console.Write(dot);
                }
                for (int i = 0; i < width - n; i++)
                {
                    Console.Write(asteriks);
                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
            }
            //Body part
            for (int mid = 0; mid < body; mid++)
            {
                for (int i = 0; i < engine; i++)
                {
                    Console.Write(dot);
                }
                Console.Write(verLine);
                for (int i = 0; i < width - (n+2); i++)
                {
                    Console.Write(revDash);
                }
                Console.Write(verLine);
                for (int i = 0; i < engine; i++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
            }
            //Bottom part
            for (int last = 0; last < engine; last++)
            {
                for (int i = engine; i > last ; i--)
                {
                    Console.Write(dot);
                }
                Console.Write(dash);
                for (int i = 0; i < width - (n + 2) + count; i++)
                {
                    Console.Write(asteriks);
                }
                Console.Write(revDash);
                for (int i = engine; i > last; i--)
                {
                    Console.Write(dot);
                }
                count += 2;
                Console.WriteLine();
            }
        }
    }
}
