using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int dividet = number;

            int midle = number % 100;
            int lastNum = number % 10;
            int secondNum = midle / 10; // second
            int firstNum = number / 100;

            int n = firstNum + secondNum;
            int m = firstNum + lastNum;

            for (int colm = 1; colm <= n; colm++)
            {
                for (int row = 1; row <= m; row++)
                {
                    if (dividet % 5 == 0)
                    {
                        dividet -= firstNum;
                        Console.Write("{0} ", dividet);
                    }
                    else if (dividet % 3 == 0)
                    {
                        dividet -= secondNum;
                        Console.Write("{0} ", dividet);
                    } 
                    else
                    {
                        dividet += lastNum;
                        Console.Write("{0} ", dividet);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
