using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] ones = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeeen", "eighteen", "nineteen" };
            string[] ten = new string[] { null, null, "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int num = 0;
            int numTens = 0;
            int numOnes = 0;

            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                if (number >= 0 && number < 10)
                {
                    Console.WriteLine(ones[number]);
                }
                else if (number >= 10 && number < 20)
                {
                    num = number % 10;
                    Console.WriteLine(teens[num]);
                }
                else if (number >= 20 && number <= 100)
                {
                    numTens = number / 10;
                    numOnes = number % 10;
                    if (number == 100)
                    {
                        Console.WriteLine("one hundred");
                    }
                    else if (numOnes == 0)
                    {
                        Console.WriteLine(ten[numTens]);
                    }
                    else
                    {
                        Console.WriteLine(ten[numTens] + " " + ones[numOnes]);
                    }
                }
                else
                {
                    Console.WriteLine("invalid number");
                }
            }
        }
    }
}
