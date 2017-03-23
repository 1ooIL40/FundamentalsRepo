using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int count = 1;
            int mid;

            for (int i = start; i <= finish; i++)
            {
                mid = start;
                for (int j = mid; j <= finish; j++)
                {
                    Console.Write("<{0}-{1}>", i, j);
                    count++;
                    if (count > max)
                    {
                        return;
                    }
                }
            }
        }
    }
}
