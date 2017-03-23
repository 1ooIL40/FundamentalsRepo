using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Tim_for_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int examTotalMins = examHour * 60 + examMinute;
            int studentTotalMins = arriveHour * 60 + arriveMinute;
            int minutesDiff = examTotalMins - studentTotalMins;

            if (minutesDiff <= 30 && minutesDiff >= 0)
            {
                Console.WriteLine("On time");
                if ( minutesDiff != 0)
                {
                    Console.WriteLine("{0} minutes before the start",minutesDiff);
                }
            }
            else if (minutesDiff < 0)
            {
                int actualMins = Math.Abs(minutesDiff);
                Console.WriteLine("late");
                if(actualMins < 60)
                {
                    Console.WriteLine("{0} minutes after the start",actualMins);
                }
                else
                {
                    int hour = actualMins / 60;
                    int minutes = actualMins % 60;
                    Console.WriteLine("{0}:{1:D2} hours after the start",hour,minutes);
                }
            }
            else if (minutesDiff >= 30)
            {
                int actualMins = Math.Abs(minutesDiff);
                Console.WriteLine("Early");
                if (actualMins >= 30 && actualMins < 60)
                {
                    Console.WriteLine("{0} minutes before the start", actualMins);
                }
                else
                {
                    int hour = actualMins / 60;
                    int minutes = actualMins % 60;
                    Console.WriteLine("{0}:{1:D2} hours before the start", hour, minutes);
                }
            }
            
        }
    }
}
