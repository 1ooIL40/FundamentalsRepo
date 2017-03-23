using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double outTime = double.Parse(Console.ReadLine());


            double firstPipe = p1 * outTime;
            double secondPipe = p2 * outTime;
            double totalLiters = firstPipe + secondPipe;

            double percentFull = totalLiters / v * 100;
            double percentFirstPipe = firstPipe / totalLiters * 100;
            double percentSecondPipe = secondPipe / totalLiters * 100;

            if (totalLiters > v)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",outTime,totalLiters - v);
            }
            else
            {
                Console.WriteLine("The pool is {0:F0}% full. Pipe 1: {1:F0}%. Pipe 2: {2:F0}%.",Math.Floor(percentFull),
                    Math.Floor(percentFirstPipe),Math.Floor(percentSecondPipe));
            }
            
            

        }
    }
}
