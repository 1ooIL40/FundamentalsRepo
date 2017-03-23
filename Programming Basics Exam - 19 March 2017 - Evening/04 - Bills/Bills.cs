using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double bill;
            double electricity = 0;
            double water = 20;
            double internet = 15;
            double otherPerMonth = 0;
            double percent = 0;
            double other = 0;
            double avg = 0;

            for (int i = 1; i <= months; i++)
            {
                bill = double.Parse(Console.ReadLine());
                electricity += bill;
                otherPerMonth = bill + water + internet;
                percent = otherPerMonth + (otherPerMonth * 0.20);
                other += percent;
            }
            avg = (electricity +(water * months) + (internet * months) + other)/ months;
            Console.WriteLine("Electricity: {0:f2} lv", electricity);
            Console.WriteLine("Water: {0:f2} lv", water * months);
            Console.WriteLine("Internet: {0:f2} lv", internet * months);
            Console.WriteLine("Other: {0:f2} lv", other);
            Console.WriteLine("Average: {0:f2} lv", avg);
        }
    }
}
