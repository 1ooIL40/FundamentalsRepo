using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            double fisrRow = double.Parse(Console.ReadLine());
            double secondRow = double.Parse(Console.ReadLine());
            double thirdRow = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string yesOrNo = Console.ReadLine().ToLower();

            double chrysanthemums = 0;
            double rouses = 0;
            double tulips = 0;

            double allRows = fisrRow + secondRow + thirdRow;
            double price = 0;
            double result = 0;
            //Spring,Summer,Аutumn,Winter

            switch (season)
            {
                case "spring":
                    chrysanthemums = 2;
                    rouses = 4.10;
                    tulips = 2.50;
                    price = chrysanthemums * fisrRow + rouses * secondRow + tulips * thirdRow;
                    if (yesOrNo == "y")
                    {
                        result = price + (price * 0.15);
                        if (thirdRow > 7)
                        {
                            result = result - (result * 0.05);
                        }
                        if (allRows > 20)
                        {
                            result = result - (result * 0.20);
                        }
                        Console.WriteLine("{0:f2}", result + 2);
                    }
                    else if (yesOrNo == "n")
                    {
                        result = price;
                        if (thirdRow > 7)
                        {
                            result = result - (result * 0.05);
                        }
                        if (allRows > 20)
                        {
                            result = result - (result * 0.20);
                        }
                        Console.WriteLine("{0:f2}", result + 2);
                    }
                    break;
                case "summer":
                    chrysanthemums = 2;
                    rouses = 4.10;
                    tulips = 2.50;
                    price = chrysanthemums * fisrRow + rouses * secondRow + tulips * thirdRow;
                    if (yesOrNo == "y")
                    {
                        result = price + (price * 0.15);
                        if (allRows > 20)
                        {
                            result = result - (result * 0.20);
                        }
                        Console.WriteLine("{0:f2}", result + 2);
                    }
                    else if (yesOrNo == "n")
                    {
                        result = price;
                        if (allRows > 20)
                        {
                            result = result - (result * 0.20);
                        }
                        Console.WriteLine("{0:f2}", result + 2);
                    }
                    break;
                case "autumn":
                    chrysanthemums = 3.75;
                    rouses = 4.50;
                    tulips = 4.15;
                    price = chrysanthemums * fisrRow + rouses * secondRow + tulips * thirdRow;
                    if (yesOrNo == "y")
                    {
                        result = price + (price * 0.15);
                        if (allRows > 20)
                        {
                            result = result - (result * 0.20);
                        }
                        Console.WriteLine("{0:f2}", result + 2);
                    }
                    else if (yesOrNo == "n")
                    {
                        result = price;
                        if (allRows > 20)
                        {
                            result = result - (result * 0.20);
                        }
                        Console.WriteLine("{0:f2}", result + 2);
                    }
                    break;
                case "winter":
                    chrysanthemums = 3.75;
                    rouses = 4.50;
                    tulips = 4.15;
                    price = chrysanthemums * fisrRow + rouses * secondRow + tulips * thirdRow;
                    if (yesOrNo == "y")
                    {
                        result = price + (price * 0.15);
                        if (secondRow >= 10)
                        {
                            result = result - (result * 0.10);
                        }
                        if (allRows > 20)
                        {
                            result = result - (result * 0.20);
                        }
                        Console.WriteLine("{0:f2}", result + 2);
                    }
                    else if (yesOrNo == "n")
                    {
                        result = price;
                        if (secondRow >= 10)
                        {
                            result = result - (result * 0.10);
                        }
                        if (allRows > 20)
                        {
                            result = result - (result * 0.20);
                        }
                        Console.WriteLine("{0:f2}", result + 2);
                    }
                    break;
            }
        }
    }
}
