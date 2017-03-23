using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string enteredUnit = Console.ReadLine();
            string exitUnit = Console.ReadLine();
            int km = 1000;
            double cm = 0.01;
            double mi = 0.000621371192;
            double inch = 39.3700787;
            double mm = 1000 ;
            double ft = 3.2808399;
            double yd = 1.0936133;
            if (enteredUnit == "m")
            {
                if (exitUnit == "m")
                {
                    Console.WriteLine(number);
                }
                else if (exitUnit == "mm")
                {
                    Console.WriteLine("{0} {1}", (number  * mm), exitUnit);
                }
                else if (exitUnit == "cm")
                {
                    Console.WriteLine("{0} {1}", (number * 100), exitUnit);
                }
                else if (exitUnit == "km")
                {
                    Console.WriteLine("{0} {1}", (number / mm), exitUnit);
                }
                else if (exitUnit == "in")
                {
                    Console.WriteLine("{0} {1}", (number * inch), exitUnit);
                }
                else if (exitUnit == "mi")
                {
                    Console.WriteLine("{0} {1}", (number * mi), exitUnit);
                }
                else if (exitUnit == "yd")
                {
                    Console.WriteLine("{0} {1}", (number * yd), exitUnit);
                }
                else if (exitUnit == "ft")
                {
                    Console.WriteLine("{0} {1}", (number * ft), exitUnit);
                }
            }
            else if (enteredUnit == "mm")
            {
                double mm1 = 0.001;
                if (exitUnit == "mm")
                {
                    Console.WriteLine(number);
                }
                else if (exitUnit == "m")
                {
                    Console.WriteLine("{0} {1}", (number *mm1), exitUnit);
                }
                else if (exitUnit == "cm")
                {
                    Console.WriteLine("{0} {1}", (number * mm1 / cm), exitUnit);
                }
                else if (exitUnit == "km")
                {
                    Console.WriteLine("{0} {1}", (number * mm1 / km), exitUnit);
                }
                else if (exitUnit == "in")
                {
                    Console.WriteLine("{0} {1}", (number * mm1 * inch), exitUnit);
                }
                else if (exitUnit == "mi")
                {
                    Console.WriteLine("{0} {1}", (number * mm1 * mi), exitUnit);
                }
                else if (exitUnit == "yd")
                {
                    Console.WriteLine("{0} {1}", (number *mm1 * yd), exitUnit);
                }
                else if (exitUnit == "ft")
                {
                    Console.WriteLine("{0} {1}", (number * mm1 * ft), exitUnit);
                }
            }
            else if (enteredUnit == "mi")
            {
                double mi1 = 1 / mi;
                if (exitUnit == "mi")
                {
                    Console.WriteLine(number);
                }
                else if (exitUnit == "mm")
                {
                    Console.WriteLine("{0} {1}", (number * mi1 * mm), exitUnit);
                }
                else if (exitUnit == "cm")
                {
                    Console.WriteLine("{0} {1}", (number * mi1 / cm), exitUnit);
                }
                else if (exitUnit == "km")
                {
                    Console.WriteLine("{0} {1}", (number * mi1 / mm), exitUnit);
                }
                else if (exitUnit == "in")
                {
                    Console.WriteLine("{0} {1}", (number *mi1 * inch), exitUnit);
                }
                else if (exitUnit == "m")
                {
                    Console.WriteLine("{0} {1}", (number * mi1), exitUnit);
                }
                else if (exitUnit == "yd")
                {
                    Console.WriteLine("{0} {1}", (number * mi1 * yd), exitUnit);
                }
                else if (exitUnit == "ft")
                {
                    Console.WriteLine("{0} {1}", (number * mi1 * ft), exitUnit);
                }
            }
            else if (enteredUnit == "in")
            {
                double inches = 1 / inch;
                if (exitUnit == "in")
                {
                    Console.WriteLine(number);
                }
                else if (exitUnit == "mm")
                {
                    Console.WriteLine("{0} {1}", (number * inches * mm), exitUnit);
                }
                else if (exitUnit == "cm")
                {
                    Console.WriteLine("{0} {1}", (number * inches / cm), exitUnit);
                }
                else if (exitUnit == "km")
                {
                    Console.WriteLine("{0} {1}", (number * inches / mm), exitUnit);
                }
                else if (exitUnit == "m")
                {
                    Console.WriteLine("{0} {1}", (number * inches), exitUnit);
                }
                else if (exitUnit == "mi")
                {
                    Console.WriteLine("{0} {1}", (number * inches * mi), exitUnit);
                }
                else if (exitUnit == "yd")
                {
                    Console.WriteLine("{0} {1}", (number * inches * yd), exitUnit);
                }
                else if (exitUnit == "ft")
                {
                    Console.WriteLine("{0} {1}", (number * inches * ft), exitUnit);
                }
            }
            else if (enteredUnit == "km")
            {
                if (exitUnit == "km")
                {
                    Console.WriteLine(number);
                }
                else if (exitUnit == "in")
                {
                    Console.WriteLine("{0} {1}", (number * km * inch), exitUnit);
                }
                else if (exitUnit == "cm")
                {
                    Console.WriteLine("{0} {1}", (number * km / cm), exitUnit);
                }
                else if (exitUnit == "m")
                {
                    Console.WriteLine("{0} {1}", (number * km), exitUnit);
                }
                else if (exitUnit == "mm")
                {
                    Console.WriteLine("{0} {1}", (number * km * mm), exitUnit);
                }
                else if (exitUnit == "mi")
                {
                    Console.WriteLine("{0} {1}", (number * km * mi), exitUnit);
                }
                else if (exitUnit == "yd")
                {
                    Console.WriteLine("{0} {1}", (number * km * yd), exitUnit);
                }
                else if (exitUnit == "ft")
                {
                    Console.WriteLine("{0} {1}", (number * km * ft), exitUnit);
                }
            }
            else if (enteredUnit == "yd")
            {
                double yd1 = 1 / yd;
                if (exitUnit == "yd")
                {
                    Console.WriteLine(number);
                }
                else if (exitUnit == "mm")
                {
                    Console.WriteLine("{0} {1}", (number * yd1 * mm), exitUnit);
                }
                else if (exitUnit == "cm")
                {
                    Console.WriteLine("{0} {1}", (number * yd1 / cm), exitUnit);
                }
                else if (exitUnit == "km")
                {
                    Console.WriteLine("{0} {1}", (number * yd1 / mm), exitUnit);
                }
                else if (exitUnit == "m")
                {
                    Console.WriteLine("{0} {1}", (number * yd1), exitUnit);
                }
                else if (exitUnit == "in")
                {
                    Console.WriteLine("{0} {1}", (number * yd1 * inch), exitUnit);
                }
                else if (exitUnit == "mi")
                {
                    Console.WriteLine("{0} {1}", (number * yd1 * mi), exitUnit);
                }
                else if (exitUnit == "ft")
                {
                    Console.WriteLine("{0} {1}", (number * yd1 * ft), exitUnit);
                }
            }
            else if (enteredUnit == "ft")
            {
                double ft1 = 1 / ft;
                if (exitUnit == "ft")
                {
                    Console.WriteLine(number);
                }
                else if (exitUnit == "mm")
                {
                    Console.WriteLine("{0} {1}", (number * ft1 * mm), exitUnit);
                }
                else if (exitUnit == "cm")
                {
                    Console.WriteLine("{0} {1}", (number * ft1 / cm), exitUnit);
                }
                else if (exitUnit == "km")
                {
                    Console.WriteLine("{0} {1}", (number * ft1 / mm), exitUnit);
                }
                else if (exitUnit == "m")
                {
                    Console.WriteLine("{0} {1}", (number * ft1), exitUnit);
                }
                else if (exitUnit == "mi")
                {
                    Console.WriteLine("{0} {1}", (number * ft1 * mi), exitUnit);
                }
                else if (exitUnit == "yd")
                {
                    Console.WriteLine("{0} {1}", (number * ft1 * yd), exitUnit);
                }
                else if (exitUnit == "in")
                {
                    Console.WriteLine("{0} {1}", (number * ft1 * inch), exitUnit); 
                }
            }
            else if (enteredUnit == "cm")
            {
                if (exitUnit == "cm")
                {
                    Console.WriteLine(number);
                }
                else if (exitUnit == "mm")
                {
                    Console.WriteLine("{0} {1}", (number * cm * mm), exitUnit);
                }
                else if (exitUnit == "m")
                {
                    Console.WriteLine("{0} {1}", (number * cm), exitUnit);
                }
                else if (exitUnit == "km")
                {
                    Console.WriteLine("{0} {1}", (number * cm / mm), exitUnit);
                }
                else if (exitUnit == "ft")
                {
                    Console.WriteLine("{0} {1}", (number * cm * ft), exitUnit);
                }
                else if (exitUnit == "mi")
                {
                    Console.WriteLine("{0} {1}", (number * cm * mi), exitUnit);
                }
                else if (exitUnit == "yd")
                {
                    Console.WriteLine("{0} {1}", (number * cm * yd), exitUnit);
                }
                else if (exitUnit == "in")
                {
                    Console.WriteLine("{0} {1}", (number * cm * inch), exitUnit);
                }
            }
        }
    }
}
