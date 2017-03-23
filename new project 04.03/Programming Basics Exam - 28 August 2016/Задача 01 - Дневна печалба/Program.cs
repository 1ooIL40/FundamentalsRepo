using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01___Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDaysInMonth = int.Parse(Console.ReadLine());
            double dayMoney = double.Parse(Console.ReadLine());
            double dolars = double.Parse(Console.ReadLine());

            double monthMoney = 0;
            double yearMoney = 0;
            double tax = 0.25;
            double realYearMoney = 0;
            double cashInLv = 0;
            double result = 0;

            monthMoney = workDaysInMonth * dayMoney;
            yearMoney = monthMoney * 12 + monthMoney * 2.5;
            realYearMoney = yearMoney - (yearMoney * tax);
            cashInLv = realYearMoney * dolars;
            result = cashInLv / 365;
            Console.WriteLine(monthMoney);
            Console.WriteLine(yearMoney);
            Console.WriteLine(realYearMoney);
            Console.WriteLine(cashInLv);

            Console.WriteLine("{0:f2}",result);

        }
    }
}
