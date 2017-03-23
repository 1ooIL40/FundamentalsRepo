using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfJunior = int.Parse(Console.ReadLine());
            int numberOfSenior = int.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();

            double sum = 0;
            double junior = 0;
            double senior = 0;
            double expanses = 0;
            double result = 0;

            if(type == "trail")
            {
                junior = 5.50;
                senior = 7;
                sum = (numberOfJunior * junior) + (numberOfSenior * senior);
                expanses = sum * 0.05;
                result = sum - expanses;
                //Console.WriteLine("{0:f2}", result);
            }
            else if (type == "cross-country")
            {
                if ((numberOfJunior + numberOfSenior) < 50)
                {
                    junior = 8;
                    senior = 9.50;
                }
                else
                {
                    junior = 8 - (8 * 0.25);
                    senior = 9.50 - (9.50 * 0.25);
                }
                sum = (numberOfJunior * junior) + (numberOfSenior * senior);
                expanses = sum * 0.05;
                result = sum - expanses;
                //Console.WriteLine("{0:f2}", result);
            }
            else if (type == "downhill")
            {
                junior = 12.25;
                senior = 13.75;
                sum = (numberOfJunior * junior) + (numberOfSenior * senior);
                expanses = sum * 0.05;
                result = sum - expanses;
                //Console.WriteLine("{0:f2}", result);
            }
            else if (type == "road")
            {
                junior = 20;
                senior = 21.50;
                sum = (numberOfJunior * junior) + (numberOfSenior * senior);
                expanses = sum * 0.05;
                result = sum - expanses;
            }
            Console.WriteLine("{0:f2}", result); // work as usual

        }
    }
}
