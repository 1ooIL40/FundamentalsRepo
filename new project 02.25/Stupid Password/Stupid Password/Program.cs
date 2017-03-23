using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            //for first simbol
            for (int simbolOne = 1; simbolOne <= n; simbolOne++)
            {
                for (int simbolTwo = 1; simbolTwo <= n; simbolTwo++)
                {
                    for (var charOne = 'a';  charOne <= 'a' + l - 1; charOne++)
                    {
                        for (var charTwo = 'a' ; charTwo <= 'a' + l - 1 ; charTwo++)
                        {
                            for (int lastSimbol = Math.Max(simbolOne,simbolTwo) + 1; lastSimbol <= n; lastSimbol++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ",simbolOne,simbolTwo,charOne,charTwo,lastSimbol);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
