using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            string categori = Console.ReadLine().ToLower();
            int numberOfPeople = int.Parse(Console.ReadLine());


            
            double vipPrice = 499.99;
            double normalPrice = 249.99;

            double priceForAllTickets = 0;
            double moneyLeft = 0;
            

            //For Travell
            if(numberOfPeople >= 1 && numberOfPeople < 5)
            {
                moneyLeft = budged - (budged * 0.75);
                if(categori == "normal")
                {
                    priceForAllTickets = normalPrice * numberOfPeople;
                    if (moneyLeft >= priceForAllTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceForAllTickets);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", priceForAllTickets - moneyLeft);
                    }
                }
                else if (categori == "vip")
                {
                    priceForAllTickets = vipPrice * numberOfPeople;
                    if (moneyLeft >= priceForAllTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceForAllTickets);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", priceForAllTickets - moneyLeft);
                    }
                }
            }
            else if (numberOfPeople >= 5 && numberOfPeople < 10)
            {
                moneyLeft = budged - (budged * 0.60);
                if (categori == "normal")
                {
                    priceForAllTickets = normalPrice * numberOfPeople;
                    if (moneyLeft >= priceForAllTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceForAllTickets);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", priceForAllTickets - moneyLeft);
                    }
                }
                else if (categori == "vip")
                {
                    priceForAllTickets = vipPrice * numberOfPeople;
                    if (moneyLeft >= priceForAllTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceForAllTickets);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", priceForAllTickets - moneyLeft);
                    }
                }
                
        }
            else if (numberOfPeople >= 10 && numberOfPeople < 25)
            {
                moneyLeft = budged - (budged * 0.50);
                if (categori == "normal")
                {
                    priceForAllTickets = normalPrice * numberOfPeople;
                    if (moneyLeft >= priceForAllTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceForAllTickets);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", priceForAllTickets - moneyLeft);
                    }
                }
                else if (categori == "vip")
                {
                    priceForAllTickets = vipPrice * numberOfPeople;
                    if (moneyLeft >= priceForAllTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceForAllTickets);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", priceForAllTickets - moneyLeft);
                    }
                }
            }
            else if (numberOfPeople >= 24 && numberOfPeople < 50)
            {
                moneyLeft = budged - (budged * 0.40);
                if (categori == "normal")
                {
                    priceForAllTickets = normalPrice * numberOfPeople;
                    if (moneyLeft >= priceForAllTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceForAllTickets);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", priceForAllTickets - moneyLeft);
                    }
                }
                else if (categori == "vip")
                {
                    priceForAllTickets = vipPrice * numberOfPeople;
                    if (moneyLeft >= priceForAllTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceForAllTickets);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", priceForAllTickets - moneyLeft);
                    }
                }
            }
            else if (numberOfPeople >= 50)
            {
                moneyLeft = budged - (budged * 0.25);
                if (categori == "normal")
                {
                    priceForAllTickets = normalPrice * numberOfPeople;
                    if (moneyLeft >= priceForAllTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceForAllTickets);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", priceForAllTickets - moneyLeft);
                    }
                }
                else if (categori == "vip")
                {
                    priceForAllTickets = vipPrice * numberOfPeople;
                    if (moneyLeft >= priceForAllTickets)
                    {
                        Console.WriteLine("Yes! You have {0:f2} leva left.", moneyLeft - priceForAllTickets);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", priceForAllTickets - moneyLeft);
                    }
                }
            }

        }
    }
}
