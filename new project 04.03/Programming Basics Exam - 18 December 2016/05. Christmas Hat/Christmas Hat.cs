using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 4 * n + 1;
            int height = 2 * n + 5;
            int topBoll = (width - 3) / 2;
            int mid = height - 6;
            int count = 1;

            char dot = '.';
            char asteriks = '*';
            char dash = '/';
            char revDash = '\\';
            char vertLine = '|';
            char minus = '-';

            //top part
            for (int top = 0; top < 1; top++)
            {
                for (int i = 1; i <= topBoll; i++)
                {
                    Console.Write(dot);
                }
                Console.Write(dash);
                Console.Write(vertLine);
                Console.Write(revDash);
                for (int i = 1; i <= topBoll; i++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
            }
            for (int top = 0; top < 1; top++)
            {
                for (int i = 1; i <= topBoll; i++)
                {
                    Console.Write(dot);
                }
                Console.Write(revDash);
                Console.Write(vertLine);
                Console.Write(dash);
                for (int i = 1; i <= topBoll; i++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
            }
            for (int top = 0; top < 1; top++)
            {
                for (int i = 1; i <= topBoll; i++)
                {
                    Console.Write(dot);
                }
                for (int i = 0; i < width - (topBoll * 2); i++)
                {
                    Console.Write(asteriks);
                }
                for (int i = 1; i <= topBoll; i++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
            }

            //Middle part
            for (int body = 1; body <= mid; body++)
            {
                for (int i = 1; i <= topBoll - count; i++)
                {
                    Console.Write(dot);
                }
                Console.Write(asteriks);
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(minus);
                }
                Console.Write(asteriks);
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(minus);
                }

                Console.Write(asteriks);
                for (int i = 1; i <= topBoll - count; i++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
                count++;
            }

            //Bott part

            for (int bot = 1; bot <= width; bot++)
            {
                Console.Write(asteriks);
            }
            Console.WriteLine();
            for (int i = 1; i <= width; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write(dot);
                }
                else
                {
                    Console.Write(asteriks);
                }
            }
            Console.WriteLine();

            for (int bot = 1; bot <= width; bot++)
            {
                Console.Write(asteriks);
            }
            Console.WriteLine();
        }
    }
}
