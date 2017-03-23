using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNmbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int one = 1; one < 10; one++)
            {
                for (int two = 1; two < 10; two++)
                {
                    for (int thre = 1; thre < 10; thre++)
                    {
                        for (int four = 1; four < 10; four++)
                        {
                            if(n % one == 0 && n % two == 0 && n % thre == 0 && n % four == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", one, two, thre, four);
                            }

                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
