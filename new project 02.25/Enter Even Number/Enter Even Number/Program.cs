using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while(true)
            {
                Console.Write("Enter even number: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Entered number is even: {0}", number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }

                }
                catch
                { 
                    Console.WriteLine("Invalid number!");
                    
                }
            }
        }
    }
}
