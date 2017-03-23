using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            int num;
            int allStudents = 0;

            double auto = 0;
            double bus = 0;
            double smallBus = 0;
            double bigBuss = 0;
            double train = 0;

            for (int i = 1; i <= numberOfGroups; i++)
            {
                num = int.Parse(Console.ReadLine());
                allStudents += num;
                if (num <= 5)
                {
                        auto += num;
                }
                else if (num <= 12)
                {
                        bus += num;
                }
                else if (num <= 25)
                {
                        smallBus += num;
                }
                else if (num <= 40)
                {
                        bigBuss += num;
                }
                else
                {
                        train += num;
                }
            }
            Console.WriteLine("{0:f2}%",((auto / allStudents) * 100));
            Console.WriteLine("{0:f2}%", ((bus / allStudents) * 100));
            Console.WriteLine("{0:f2}%", ((smallBus / allStudents) * 100));
            Console.WriteLine("{0:f2}%", ((bigBuss / allStudents) * 100));
            Console.WriteLine("{0:f2}%", ((train / allStudents) * 100));
        }
    }
}
