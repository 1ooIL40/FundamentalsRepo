using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            int firstSPeed = int.Parse(Console.ReadLine());
            int firstTimeM = int.Parse(Console.ReadLine());
            int secondTimeM = int.Parse(Console.ReadLine());
            int thirdTimeM = int.Parse(Console.ReadLine());


            double firstTimeH = (double)firstTimeM / 60;
            double secondTimeH = (double)secondTimeM / 60;
            double thirdTimeH = (double)thirdTimeM / 60;

            double withFirstSpeed = firstSPeed * firstTimeH;
            double upWithThen = (firstSPeed + (firstSPeed * 0.1));
            double lowWithFive = (upWithThen - (upWithThen * 0.05));
            double sum = (upWithThen * secondTimeH + lowWithFive * thirdTimeH + withFirstSpeed);

            Console.WriteLine("{0:f2}",sum);
        }
    }
}
