using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string asteriks = "*";
            string spacess = " ";
            string dash = "/";
            string verticalLine = "|";
            int glassesFrame = 2 * n;
            double middleThing = 0d;
            Math.Round(middleThing =(n - 1) / 2 - 1);
            //TOP
            for (int i = 0; i < glassesFrame; i++)
            {
                Console.Write(asteriks);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(spacess);
            }
            for (int i = 0; i < glassesFrame; i++)
            {
                Console.Write(asteriks);
            }
            Console.WriteLine();

            //BODY
            for (int i = 0; i < n - 2; i++)
            {
                //Left Part
                for (int k = glassesFrame; k > 0; k--)
                {
                    if (k == 1)
                    {
                        Console.Write(asteriks);
                    }
                    else if (k == glassesFrame)
                    {
                        Console.Write(asteriks);
                    }
                    else
                    {
                        Console.Write(dash);
                    }
                    
                }
                if (middleThing == i)
                {
                    for (int j = n; j < glassesFrame; j++)
                    {
                        Console.Write(verticalLine);
                    }
                }

                //Middle betwin the 2 glasses
                if (middleThing != i)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write(spacess);
                    }
                }

                //Right Part
                for (int k = glassesFrame; k > 0; k--)
                {
                    if (k == 1)
                    {
                        Console.Write(asteriks);
                    }
                    else if (k == glassesFrame)
                    {
                        Console.Write(asteriks);
                    }
                    else
                    {
                        Console.Write(dash);
                    }
                }
                Console.WriteLine();
            }   

            //BOTTOM
            for (int i = 0; i < glassesFrame; i++)
            {
                Console.Write(asteriks);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(spacess);
            }
            for (int i = 0; i < glassesFrame; i++)
            {
                Console.Write(asteriks);
            }
            Console.WriteLine(); 
        }
    }
}
