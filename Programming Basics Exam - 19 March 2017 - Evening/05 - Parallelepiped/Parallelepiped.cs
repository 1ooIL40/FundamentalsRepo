using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 4 * n + 4;
            int width = 3 * n + 1;

            int titas = n - 2;
            int body = (height / 2) - 1;
            int count = 1;

            char plus = '+';
            char ti = '~';
            char verLine = '|';
            char revDash = '\\';
            char dot = '.';

            //First Row
            for (int first = 0; first < 1; first++)
            {
                Console.Write(plus);
                for (int i = 0; i < titas; i++)
                {
                    Console.Write(ti);
                }
                Console.Write(plus);
                for (int i = 0; i < width - n; i++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
            }

            //top body
            for (int bodyRow = 1; bodyRow <= body; bodyRow++)
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.Write(verLine);
                }
                for (int i = 1; i < bodyRow; i++)
                {
                    Console.Write(dot);
                }
                Console.Write(revDash);
                for (int i = 1; i <= titas; i++)
                {
                    Console.Write(ti);
                }
                Console.Write(revDash);
                for (int i = bodyRow; i < body; i++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
            }

            //bot body
            for (int bodyRow = 1; bodyRow <= body; bodyRow++)
            {
                for (int i = 2; i <= bodyRow; i++)
                {
                    Console.Write(dot);
                }
                Console.Write(revDash);
                for (int i = bodyRow; i < body; i++)
                {
                    Console.Write(dot);
                }
                Console.Write(verLine);
                for (int i = 0; i < titas; i++)
                {
                    Console.Write(ti);
                }
                Console.Write(verLine);
                Console.WriteLine();
            }
            //last row
            for (int first = 0; first < 1; first++)
            {
                for (int i = 0; i < width - n; i++)
                {
                    Console.Write(dot);
                }
                Console.Write(plus);
                for (int i = 0; i < titas; i++)
                {
                    Console.Write(ti);
                }
                Console.Write(plus);
                Console.WriteLine();
            }

        }
    }
}
