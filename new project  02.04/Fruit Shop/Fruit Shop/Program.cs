using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] fruit = new string[] { "banana", "apple", "orange", "grapefruit", "kiwi", "pineapple", "grapes" };
            //string[] day = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                var banana = 2.50;
                var apple = 1.20;
                var orange = 0.85;
                var grapefruit = 1.45;
                var kiwi = 2.70;
                var pineapple = 5.50;
                var grapes = 3.85;

                if (fruit == "banana")
                {
                    Console.WriteLine(quantity * banana);
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(quantity * apple);
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(quantity * orange);
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(quantity * grapefruit);
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(quantity * kiwi);
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(quantity * pineapple);
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(quantity * grapes);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "workday")
            {
                Console.WriteLine("error");
            }
            else //if (day == "Saturday" || day == "Sunday")
            {
                var banana = 2.70;
                var apple = 1.25;
                var orange = 0.90;
                var grapefruit = 1.60;
                var kiwi = 3.00;
                var pineapple = 5.60;
                var grapes = 4.20;

                if (fruit == "banana")
                {
                    Console.WriteLine(quantity * banana);
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(quantity * apple);
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(quantity * orange);
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(quantity * grapefruit);
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(quantity * kiwi);
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(quantity * pineapple);
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(quantity * grapes);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}
