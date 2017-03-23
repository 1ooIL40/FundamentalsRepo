using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_days_on_the_Earth
{
    class Program
    {
        static void Main(string[] args)
        {
            string H = Console.ReadLine();
            string m = Console.ReadLine();
            string date = H + ":" + m;
            DateTime outputDate = DateTime.ParseExact(date,"dd-MM-yyyy",null);
            DateTime newDate = outputDate.AddDays(999);
            Console.WriteLine(newDate.ToString("dd-MM-yyyy"));
        }
    }
}
