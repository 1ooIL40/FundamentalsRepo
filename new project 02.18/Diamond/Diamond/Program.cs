using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = (n - 1) / 2;
            int midOdd = n - 2 * leftRight - 2;
            int midEven = n - 2 * leftRight;
            int count = 0;

            string underscore = "-";
            string asteriks = "*";


            if (n > 0 && n <= 2)
            {
                if (n == 1)
                {
                    Console.Write(asteriks);
                }
                else
                {
                    Console.Write(asteriks);
                    Console.Write(asteriks);
                }
                Console.WriteLine();
            }
            else
            {
                if (n % 2 != 0)
                {
                    //First row
                    for (int i = 0; i < 1; i++)
                    {

                        for (int k = 0; k < leftRight; k++)
                        {
                            Console.Write(underscore);
                        }
                        Console.Write(asteriks);
                        for (int k = 0; k < leftRight; k++)
                        {
                            Console.Write(underscore);
                        }

                    }
                    Console.WriteLine();

                    //Top Part

                    for (int i = 1; i < leftRight; i++)
                    {
                        for (int k = 0; k < leftRight - i; k++)
                        {
                            Console.Write(underscore);
                        }
                        Console.Write(asteriks);

                        if (midEven >= 0)
                        {
                            Console.WriteLine(midEven);
                            count += 2;
                            for (int z = 0; z < count - 1; z++)
                            {
                                Console.Write(underscore);
                            }
                            Console.Write(asteriks);
                        }

                        for (int k = 0; k < leftRight - i; k++)
                        {
                            Console.Write(underscore);
                        }

                        Console.WriteLine();
                    }

                    //Midle Part
                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write(asteriks);
                    }
                    for (int i = 1; i <= n - 2; i++)
                    {
                        Console.Write(underscore);
                    }
                    for (int i = n - 1; i < n; i++)
                    {
                        Console.Write(asteriks);
                    }
                    Console.WriteLine();
                    //Bottom Part
                    for (int i = leftRight; i > 1; i--)
                    {
                        for (int k = leftRight - i; k >= 0; k--)
                        {
                            Console.Write(underscore);
                        }
                        Console.Write(asteriks);

                        if (midEven >= 0)
                        {
                            for (int z = 0; z < count - 1; z++)
                            {
                                Console.Write(underscore);
                            }
                            Console.Write(asteriks);
                            count -= 2;
                        }
                        for (int k = leftRight; k >= i; k--)
                        {
                            Console.Write(underscore);
                        }

                        Console.WriteLine();
                    }
                    //Last row
                    for (int i = 0; i < 1; i++)
                    {

                        for (int k = 0; k < leftRight; k++)
                        {
                            Console.Write(underscore);
                        }
                        Console.Write(asteriks);
                        for (int k = leftRight; k > 0; k--)
                        {
                            Console.Write(underscore);
                        }
                    }
                    Console.WriteLine();
                }
                // for % 2 ==0
                else
                {
                    //First row
                    for (int i = 0; i < 1; i++)
                    {

                        for (int k = 0; k < leftRight; k++)
                        {
                            Console.Write(underscore);
                        }
                        Console.Write(asteriks);
                        Console.Write(asteriks);
                        for (int k = 0; k < leftRight; k++)
                        {
                            Console.Write(underscore);
                        }

                    }
                    Console.WriteLine();

                    //Top Part

                    for (int i = 1; i < leftRight; i++)
                    {
                        for (int k = 0; k < leftRight - i; k++)
                        {
                            Console.Write(underscore);
                        }
                        Console.Write(asteriks);

                        if (midOdd >= 0)
                        {
                            count += 2;
                            for (int z = 0; z < count; z++)
                            {
                                Console.Write(underscore);
                            }
                            Console.Write(asteriks);
                        }

                        for (int k = 0; k < leftRight - i; k++)
                        {
                            Console.Write(underscore);
                        }

                        Console.WriteLine();
                    }

                    //Midle Part
                    for (int i = 0; i < 1; i++)
                    {
                        Console.Write(asteriks);
                    }
                    for (int i = 1; i <= n - 2; i++)
                    {
                        Console.Write(underscore);
                    }
                    for (int i = n - 1; i < n; i++)
                    {
                        Console.Write(asteriks);
                    }
                    Console.WriteLine();
                    //Bottom Part
                    for (int i = leftRight; i > 1; i--)
                    {
                        for (int k = leftRight - i; k >= 0; k--)
                        {
                            Console.Write(underscore);
                        }
                        Console.Write(asteriks);

                        if (midOdd >= 0)
                        {
                            for (int z = 0; z < count; z++)
                            {
                                Console.Write(underscore);
                            }
                            Console.Write(asteriks);
                            count -= 2;
                        }
                        for (int k = leftRight; k >= i; k--)
                        {
                            Console.Write(underscore);
                        }

                        Console.WriteLine();
                    }
                    //Last row
                    for (int i = 0; i < 1; i++)
                    {

                        for (int k = 0; k < leftRight; k++)
                        {
                            Console.Write(underscore);
                        }
                        Console.Write(asteriks);
                        Console.Write(asteriks);
                        for (int k = leftRight; k > 0; k--)
                        {
                            Console.Write(underscore);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
