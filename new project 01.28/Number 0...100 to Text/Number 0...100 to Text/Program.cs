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
            string[] ones = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven","eight", "nine" };
            string[] teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeeen", "eighteen", "nineteen" };
            string[] ten = new string[] { null, null, "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int num = 0;

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
                else if (number >= 20 && number < 30)
                {
                    if (number == 20)
                    {
                        num = number / 10;
                        Console.WriteLine(ten[num]);
                    }
                    else
                    {
                        num = number % 20;
                        Console.WriteLine("twenty" + " " + ones[num]);
                    }
                }
                else if (number >= 30 && number < 40)
                {
                    if (number == 30)
                    {
                        num = number / 10;
                        Console.WriteLine(ten[num]);
                    }
                    else
                    {
                        num = number % 30;
                        Console.WriteLine("thirty" + " " + ones[num]);
                    }
                }
                else if (number >= 40 && number < 50)
                {
                    if (number == 40)
                    {
                        num = number / 10;
                        Console.WriteLine(ten[num]);
                    }
                    else
                    {
                        num = number % 40;
                        Console.WriteLine("fourty" + " " + ones[num]);
                    }
                }
                else if (number >= 50 && number < 60)
                {
                    if (number == 50)
                    {
                        num = number / 10;
                        Console.WriteLine(ten[num]);
                    }
                    else
                    {
                        num = number % 50;
                        Console.WriteLine("fifty" + " " + ones[num]);
                    }
                }
                else if (number >= 60 && number < 70)
                {
                    if (number == 60)
                    {
                        num = number / 10;
                        Console.WriteLine(ten[num]);
                    }
                    else
                    {
                        num = number % 60;
                        Console.WriteLine("sixty" + " " + ones[num]);
                    }
                }
                else if (number >= 70 && number < 80)
                {
                    if (number == 70)
                    {
                        num = number / 10;
                        Console.WriteLine(ten[num]);
                    }
                    else
                    {
                        num = number % 70;
                        Console.WriteLine("seventy" + " " + ones[num]);
                    }
                }
                else if (number >= 80 && number < 90)
                {
                    if (number == 80)
                    {
                        num = number / 10;
                        Console.WriteLine(ten[num]);
                    }
                    else
                    {
                        num = number % 80;
                        Console.WriteLine("eighty" + " " + ones[num]);
                    }
                }
                else
                {
                    if (number == 100)
                    {
                        Console.WriteLine("one hundred");
                    }
                    else
                    {
                        if (number == 90)
                        {
                            num = number / 10;
                            Console.WriteLine(ten[num]);
                        }
                        else
                        {
                            num = number % 90;
                            Console.WriteLine("ninety" + " " + ones[num]);
                        }
                    }
                }
            }
           
        }
    }
}
