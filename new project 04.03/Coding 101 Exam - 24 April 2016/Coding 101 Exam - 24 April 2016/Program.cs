using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_101_Exam___24_April_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());

            double areaWeNeed = 0;
            double tilesWeNeed = 0;
            double timeWeNeed = 0;

            double areaN = n * n;
            double areaWL = w * l;
            double areaMO = m * o;

            areaWeNeed = areaN - areaMO;
            tilesWeNeed = areaWeNeed / areaWL;
            timeWeNeed = tilesWeNeed * 0.2;

            Console.Write("{0}\n{1}\n",tilesWeNeed,timeWeNeed);
        }
    }
}
