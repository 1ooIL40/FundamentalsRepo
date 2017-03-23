using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritatedMoney = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine()); // year he hav to livs

            double money = inheritatedMoney;
            int age = 19;

            for (int liveTime = 1800; liveTime <= year; liveTime++)
            {

                if (liveTime % 2 == 0)
                {
                    money -= 12000;
                }
                if (liveTime % 2 == 1)
                {
                    money = money - (12000 + (age * 50));
                    age += 2;
                }
            }
            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs(money));
            }
        }
    }
}
