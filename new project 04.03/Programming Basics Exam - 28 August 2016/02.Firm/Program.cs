using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursWeNeed = int.Parse(Console.ReadLine());
            int daysWeHave = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine()); //work + hours

            double percentEducation = daysWeHave - (daysWeHave * 0.1);
            double hoursForWork = percentEducation * 8;
            double moreWork = (employees * 2) * daysWeHave;
            double allHours = hoursForWork + moreWork;
            double result = Math.Floor(allHours);

            if (result >= hoursWeNeed)
            {
                Console.WriteLine("Yes!{0} hours left.", result - hoursWeNeed);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.",hoursWeNeed - result);
            }


        }
    }
}
