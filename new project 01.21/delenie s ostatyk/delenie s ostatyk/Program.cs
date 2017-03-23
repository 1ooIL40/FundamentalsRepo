using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delenie_s_ostatyk
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 143;
            var lastDigit = number % 10;
            number = number / 10;
            var secondDigit = number % 10;
            Console.WriteLine(secondDigit);
        }
    }
}
