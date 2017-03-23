using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_from_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var first = DateTime.Now;

            Console.WriteLine("{0}{1}{0}", new string('.',n ), new string('*',3     * n));
            for (int k = n - 1; k > 0; k--)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', k), new string('.', ((5 * n - 2 - 2 * k))));
            }
            Console.WriteLine("{0}", new string('*', 5 * n));
            int i = 1;
            for ( i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', (5 * n - 2 - 2 * i)));
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('*', (5 * n - 2 - 2 * i)));

            var second = DateTime.Now;

            Console.WriteLine(second - first); //00:12:14.9300356 for n = 1000
        }
    }
}
