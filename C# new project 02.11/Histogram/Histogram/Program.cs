using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num < 400)
                {
                    p2++;
                }
                else if (num < 600)
                {
                    p3++;
                }
                else if (num < 800)
                {
                    p4++;
                }
                else if (num <= 1000)
                {
                    p5++;
                }
            }

            Console.WriteLine("p1= {0:0.00}%", p1 / n * 100);
            Console.WriteLine("p2= {0:0.00}%", p2 / n * 100);
            Console.WriteLine("p3= {0:0.00}%", p3 / n * 100);
            Console.WriteLine("p4= {0:0.00}%", p4 / n * 100);
            Console.WriteLine("p5= {0:0.00}%", p5 / n * 100);
        }
    }
}
