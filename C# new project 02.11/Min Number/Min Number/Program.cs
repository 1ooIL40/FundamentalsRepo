using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (minValue > num)
                {
                    minValue = num;
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
