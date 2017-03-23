using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double S = 0;
                S = a * a;
                Console.WriteLine("{0:0.000}",S);
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double P = 0;
                P = Math.PI * (r * r);
                Console.WriteLine("{0:0.000}",P);
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = 0;
                S = a * b;
                Console.WriteLine("{0:0.000}",S);
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double Ha = double.Parse(Console.ReadLine());
                double S = 0;
                S = 0.5 * a * Ha;
                Console.WriteLine("{0:0.000}",S);
            }
            else
            {
                Console.WriteLine("wrong figure try again");
            }
        }
    }
}
