using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drow_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int topWidth = (n + 1) * 4;
            int midWidth = ((n + 1) * 2) - 4;
            int stopWidth = (topWidth - 4) / 2;
            int count = 0;


            string dot = ".";
            string underscore = "_";
            string dash = "/";
            string revDash = "\\";

            
            //Top line
            for (int topLine = 0; topLine < 1; topLine++)
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.Write(dot);
                }
                for (int i = 0; i <= n*2; i++)
                {
                    Console.Write(underscore);
                }
                for (int i = 0; i <= n; i++)
                {
                    Console.Write(dot);
                }

                
            }
            Console.WriteLine();

            //Top body part
            for (int topBodyPart = 1; topBodyPart <= n; topBodyPart++)
            {
                //left part
                for (int left = n; left >= topBodyPart; left--)
                {
                    Console.Write(dot);
                }
                Console.Write(dash);
                Console.Write(dash);

                //middle part
                for (int mid = 0; mid <= midWidth + count ; mid++)
                {
                    Console.Write(underscore);
                }
                count += 2;
                //right part
                Console.Write(revDash);
                Console.Write(revDash);
                for (int right = n; right >= topBodyPart; right--)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
            }


            //stop! part
            for (int stop = 0; stop < 1; stop++)
            {
                Console.Write(dash);
                Console.Write(dash);

                for (int i = 0; i < stopWidth - 3; i++)
                {
                    Console.Write(underscore);
                }

                Console.Write("STOP!");

                for (int i = 0; i < stopWidth - 3; i++)
                {
                    Console.Write(underscore);
                }


                Console.Write(revDash);
                Console.Write(revDash);
            }
            Console.WriteLine();

            //Bottom body part
            for (int firstRow = 0; firstRow < 1; firstRow++)
            {
                Console.Write(revDash);
                Console.Write(revDash);
                for (int i = 0; i < midWidth + count + 1; i++)
                {
                    Console.Write(underscore);
                }
                Console.Write(dash);
                Console.Write(dash);
            }
            Console.WriteLine();

            for (int botBodyPart = 1; botBodyPart < n; botBodyPart++)
            {
                for (int left = 0; left < botBodyPart; left++)
                {
                    Console.Write(dot);
                }
                Console.Write(revDash);
                Console.Write(revDash);

                for (int mid = 1; mid < midWidth + count; mid++)
                {
                    Console.Write(underscore);
                }
                count -= 2;
                Console.Write(dash);
                Console.Write(dash);
                for (int right = 0; right < botBodyPart; right++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();

            }

            Console.WriteLine();
        }
    }
}
