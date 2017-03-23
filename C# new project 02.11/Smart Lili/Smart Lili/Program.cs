using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageOfLili = int.Parse(Console.ReadLine());
            double priceOfLaundry = double.Parse(Console.ReadLine());
            double priceOfToy = double.Parse(Console.ReadLine());

            int numberOfToys = 0;
            int moneyReceived = 0;
            double soldToys = 0;
            int moneyTaken = 0;
            double savedMoney = 0;

            double moneyLeft = 0;
            double moneyInNeed = 0;

            for (int i = 1; i <= ageOfLili; i++)
            {
                if(i % 2 != 0)
                {
                    numberOfToys++;
                }
                if (i % 2 == 0)
                {
                    moneyTaken++;
                    moneyReceived += moneyTaken * 10;
                }
            }
            soldToys = numberOfToys * priceOfToy;
            savedMoney = moneyReceived - moneyTaken + soldToys;

            if(savedMoney < priceOfLaundry)
            {
                moneyInNeed = priceOfLaundry - savedMoney;
                Console.WriteLine("No! {0:f}",moneyInNeed);
            }
            else if (savedMoney > priceOfLaundry)
            {
                moneyLeft = savedMoney - priceOfLaundry;
                Console.WriteLine("Yes! {0:f}",moneyLeft);
            }
            else
            {
                Console.WriteLine("Yes! {0:f}",0);
            }

            //Console.WriteLine("Saved Money = " + savedMoney);

            //Console.WriteLine("Money Taken = " + moneyTaken);
            //Console.WriteLine("Sold Toys = " + soldToys);
            //Console.WriteLine("Number of Toys = " + numberOfToys);
            //Console.WriteLine("Money Received = " + moneyReceived);
        }
    }
}
