using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int oldPeople = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine().ToLower();

            //train,bus,boat,airplane
            double transportMoney = 0;
            double nightsSleep = 0;
            double comission = 0;
            double allSum = 0;

            int group = oldPeople + students;

            if (transport == "train")
            {   
                if (group >= 50)
                {
                    transportMoney = (oldPeople * 24.99 + students * 14.99);
                    nightsSleep = nights * 82.99;
                    comission = (transportMoney + nightsSleep) * 0.10;
                    allSum = transportMoney + nightsSleep + comission;

                    Console.WriteLine("{0:f2}", allSum);
                }
                else
                {
                    transportMoney = (oldPeople * 24.99 + students * 14.99) * 2;
                    nightsSleep = nights * 82.99;
                    comission = (transportMoney + nightsSleep) * 0.10;
                    allSum = transportMoney + nightsSleep + comission;

                    Console.WriteLine("{0:f2}", allSum);
                }
            }
            else if (transport == "bus")
            {
                transportMoney = (oldPeople * 32.50 + students * 28.50) * 2;
                nightsSleep = nights * 82.99;
                comission = (transportMoney + nightsSleep) * 0.10;
                allSum = transportMoney + nightsSleep + comission;
                Console.WriteLine("{0:f2}", allSum);

            }
            else if (transport == "boat")
            {
                transportMoney = (oldPeople * 42.99 + students * 39.99) * 2;
                nightsSleep = nights * 82.99;
                comission = (transportMoney + nightsSleep) * 0.10;
                allSum = transportMoney + nightsSleep + comission;
                Console.WriteLine("{0:f2}", allSum);

            }
            else if (transport == "airplane")
            {
                transportMoney = (oldPeople * 70.00 + students * 50.00) * 2;
                nightsSleep = nights * 82.99;
                comission = (transportMoney + nightsSleep) * 0.10;
                allSum = transportMoney + nightsSleep + comission;
                Console.WriteLine("{0:f2}",allSum);
            }
        }
    }
}
