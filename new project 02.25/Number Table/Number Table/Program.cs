using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int rightPart = 0;

            for (int row = 0; row <= n -1; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    do
                    {
                        num = row + col + 1;
                        rightPart = 2 * n - num;
                        if (num <= n)
                        {
                            Console.Write(num);
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(rightPart);
                            Console.Write(" ");
                        }
                        break;
                    }
                    while (col != n);
                }
                Console.WriteLine();
            }
        }
    }
}
