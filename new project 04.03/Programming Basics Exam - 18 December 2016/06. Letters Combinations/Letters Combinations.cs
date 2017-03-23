using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char exeption = char.Parse(Console.ReadLine());
            int count = 0;

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    for (int k = first; k <= second; k++)
                    {
                        if(i != exeption && j != exeption && k != exeption)
                        {
                            Console.Write("{0}{1}{2} ", (char)i, (char)j, (char)k);
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
