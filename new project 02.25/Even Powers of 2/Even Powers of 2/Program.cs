﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int count = 0;

            for (int i = 0; i <= n; i+=2)
            {
                count++;
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}
