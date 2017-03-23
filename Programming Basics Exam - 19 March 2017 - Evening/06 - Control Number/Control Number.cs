using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int ctrlNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int result = 0;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum = (i * 2 + j * 3);
                    result += sum;
                    count++;
                    if (result >= ctrlNum)
                    {
                        Console.WriteLine("{0} moves", count);
                        Console.WriteLine("Score: {0} >= {1}", result, ctrlNum);
                        return;
                    }
                }
            }
            if(result < ctrlNum)
            {
            //    Console.WriteLine("{0} moves", count);
            //    Console.WriteLine("Score: {0} >= {1}", result, ctrlNum);
            //}
            //else
            //{
                Console.WriteLine("{0} moves",count);
            }
        }
    }
}
