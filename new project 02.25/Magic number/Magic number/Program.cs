using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int magicNumber;

            for (int one = 1; one <= 9; one++)
            {
                for (int two = 1; two <= 9; two++)
                {
                    for (int thre = 1; thre <= 9; thre++)
                    {
                        for (int four = 0; four <= 9; four++)
                        {
                            for (int five = 1; five <= 9; five++)
                            {
                                for (int six = 1; six <= 9; six++)
                                {
                                    magicNumber = one * two * thre * four * five * six;
                                    if (magicNumber == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", one, two, thre, four, five, six);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
