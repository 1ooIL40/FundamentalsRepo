using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int sum = 0;
            int result = 0;
            int a = 1;
            int e = 2;
            int i = 3;
            int o = 4;
            int u = 5;

            for (int j = 0; j < word.Length; j++)
            {
                if (word[j] == 'a')
                {
                    sum += a;
                }
                if (word[j] == 'e')
                {
                    sum += e;
                }
                if (word[j] == 'i')
                {
                    sum += i;
                }
                if (word[j] == 'o')
                {
                    sum += o;
                }
                if (word[j] == 'u')
                {
                    sum += u;
                }
            }
            result += sum;
            Console.WriteLine(result);
        }
    }
}
