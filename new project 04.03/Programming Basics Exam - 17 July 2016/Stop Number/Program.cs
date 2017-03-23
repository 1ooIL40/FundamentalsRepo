using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int stoper = int.Parse(Console.ReadLine());

            for (int i = secondNumber; i >= firstNumber ; i--)
            {
                if(i % 3 == 0)
                {
                    if( i % 2 == 0)
                    {
                        if (i == stoper)
                        {
                            break;
                        }
                        Console.Write("{0} ",i);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
