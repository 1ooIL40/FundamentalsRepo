using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());
            int daysInYear = 365;
            int workDays = daysInYear - freeDays;

            int catSleepTimeNeed = 30000; // in minutes
            int workDaysPlay = workDays * 63; // minutes
            int freeDaysPlay = freeDays * 127; //minutes

            int outputMinutes = 0;
            int outputHours = 0;

            int optimalDayPlayed = workDaysPlay + freeDaysPlay;
            
            if (catSleepTimeNeed < optimalDayPlayed)
            {
                int run = optimalDayPlayed - catSleepTimeNeed;
                outputHours = run / 60;
                outputMinutes = run % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",outputHours,outputMinutes);

            }
            else
            {
                int sleepWell = catSleepTimeNeed - optimalDayPlayed;
                outputHours = sleepWell / 60;
                outputMinutes = sleepWell % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",outputHours,outputMinutes);
            }

        }
    }
}
