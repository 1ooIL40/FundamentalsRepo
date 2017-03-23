using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoom = double.Parse(Console.ReadLine());
            double kittchen = double.Parse(Console.ReadLine());
            double priceKvM = double.Parse(Console.ReadLine());

            double secondRoom = smallestRoom + (smallestRoom * 0.1);
            double thirdRoom = secondRoom + (secondRoom * 0.1);
            double bathRoom = smallestRoom / 2;
            double allRooms = smallestRoom + kittchen + secondRoom + thirdRoom + bathRoom;
            double apartment = allRooms + (allRooms * 0.05);
            
            Console.WriteLine("{0:f2}",priceKvM*apartment);


        }
    }
}
