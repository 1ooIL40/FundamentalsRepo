using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int studentsNum = int.Parse(Console.ReadLine());
            double grades;
            double avrg = 0;
            double sum = 0;
            double fail = 0;
            double lesThenFour = 0;
            double lesThenFive = 0;
            double best = 0;

            for (int i = 1; i <= studentsNum; i++)
            {
                grades = double.Parse(Console.ReadLine());
                sum += grades;

                if (grades < 3)
                {
                    fail++;
                }
                else if (grades < 4)
                {
                    lesThenFour++;
                }
                else if (grades < 5)
                {
                    lesThenFive++;
                }
                else if (grades <= 6)
                {
                    best++;
                }

            }
            avrg = sum / studentsNum;
            Console.WriteLine("Top students: {0:f2}%", (best / studentsNum) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (lesThenFive / studentsNum) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (lesThenFour / studentsNum) * 100);
            Console.WriteLine("Fail: {0:f2}%", (fail / studentsNum) * 100);
            Console.WriteLine("Average: {0:f2}", avrg);
        }
    }
}
