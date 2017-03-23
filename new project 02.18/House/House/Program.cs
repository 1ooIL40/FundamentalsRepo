using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int roof = (n + 1) / 2;
            int intervalOdd = n / 2;
            int intervalEven = (n  - 2) / 2;
            int count = 4;


            string asteriks = "*";
            string verticalLine = "|";
            string minus = "-";

            //ROOF
            //first row
            for (int i = 0; i < 1; i++)
            {
                /*if(n == 2)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(asteriks);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(verticalLine);
                    }
                }
                else
                {*/
                    if (n % 2 != 0)
                    { 
                        for (int j = 0; j < intervalOdd; j++)
                        {
                            Console.Write(minus);
                        }
                        for (int j = 0; j < 1; j++)
                        {
                            Console.Write(asteriks);
                        }
                        for (int j = 0; j < intervalOdd; j++)
                        {
                            Console.Write(minus);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < intervalEven; j++)
                        {
                            Console.Write(minus);
                        }
                        for (int j = 0; j < 2; j++)
                        {
                            Console.Write(asteriks);
                        }
                        for (int j = 0; j < intervalEven; j++)
                        {
                            Console.Write(minus);
                        }
                    }
                }
                Console.WriteLine();
           // }
            //middle rows
            if (n > 4)
            {
                for (int i = 1; i < roof - 1; i++)
                {
                    if (n % 2 == 0)
                    {
                        for (int j = i; j < intervalOdd - 1; j++)
                        {
                            Console.Write(minus);
                        }
                        for (int j = 0; j < count; j++)
                        {
                            Console.Write(asteriks);
                        }
                        for (int j = i; j < intervalOdd - 1; j++)
                        {
                            Console.Write(minus);
                        }
                        count += 2;   
                    }
                    else
                    {
                        for (int j = i; j < intervalOdd; j++)
                        {
                            Console.Write(minus);
                        }
                        for (int j = 1; j < count; j++)
                        {
                            Console.Write(asteriks);
                        }
                        for (int j = i; j < intervalOdd; j++)
                        {
                            Console.Write(minus);
                        }
                        count +=2;
                    }
                    Console.WriteLine();
                }
            }
            //last part of the roof
            if (n > 2)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(asteriks);
                }
                Console.WriteLine();
            }

            //Hous
            for (int i = 0; i < intervalOdd; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write(verticalLine);
                }
                for (int j = 0; j < n-2; j++)
                {
                    Console.Write(asteriks);
                }
                for (int j = n; j > n -1; j--)
                {
                    Console.Write(verticalLine);
                }
                Console.WriteLine();
            }

        }
    }
}
