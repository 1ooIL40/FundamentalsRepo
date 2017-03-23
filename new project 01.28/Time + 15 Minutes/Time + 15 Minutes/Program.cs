using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            string H = Console.ReadLine();
            string m = Console.ReadLine();
            if (H == "0" && m == "0")
            {
                Console.WriteLine("0:15");
            }
            else
            {
                string Time = H + ":" + m;
                DateTime newTime = DateTime.ParseExact(Time, "H:mm", null);
                DateTime minute = newTime.AddMinutes(15);
                Console.WriteLine(minute.ToString("H:mm"));
            }
        }
    }
}
