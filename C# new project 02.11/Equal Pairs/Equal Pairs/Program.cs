using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int len = 0;
            int currSum = 0;
            int prevSum = 0;
            int counter = 0;
            int currMaxDiff = 0;
            int maxDiff = 0;
            int sum = 0;

            if (n < 1)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                len = n * 2;
                for (int i = 0; i < len; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    sum += num;
                    counter++;
                    if (currSum == sum && i == (len-1) )
                    {
                        Console.WriteLine("Yes, value={0}", currSum);
                        
                    }
                    if (currSum != sum && i == (len-1))
                    {
                        prevSum = currSum;
                        currMaxDiff = (prevSum - sum);
                        if (n == 1)
                        {
                            Console.WriteLine("Yes, value={0}", sum);
                        }
                        else 
                        {
                            maxDiff = Math.Abs(currMaxDiff);
                            Console.WriteLine("No, maxdiff={0}",maxDiff);
                        }
                    }
                    if (counter == 2)
                    {
                        currSum = sum;
                        sum = 0;

                        counter = 0;
                    }

                }
            }
            //Console.WriteLine(sum);
        }
    }
}
