using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = number; i > 0; i--)
            {
                for (int j = 0; j <= number -i; j++)
                {
                    if (count > number)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(count);
                        Console.Write(" ");
                        count++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
