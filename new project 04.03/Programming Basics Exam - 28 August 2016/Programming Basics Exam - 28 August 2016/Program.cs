using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_Exam___28_August_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int axeHandle = n / 2;
            int lineCount = n * 3;
            int under = n / 2 - 1;

            for (int i = 0; i < n; i++)
            {
                for (int line = 0; line < lineCount; line++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int star = 0; star < i; star++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int line = 0; line < 2*n-i-2; line++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                
            }

            //handle
            for (int handle = 0; handle < axeHandle; handle++)
            {
                for (int line = 0; line < lineCount; line++)
                {
                    Console.Write("*");
                }
                Console.Write("*");
                for (int star = 0; star < n - 1; star++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int line = 0; line < 2 * n - n - 1; line++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
            //under the handle
            int innerLines = n;
            int endLines = n - 1;
            for (int handle = 0; handle < under; handle++)
            {
                for (int line = 0; line < lineCount; line++)
                {
                    Console.Write("-");
                }
                lineCount--;
                Console.Write("*");
                for (int star = 0; star < innerLines - 1; star++)
                {
                    Console.Write("-");
                }
                innerLines += 2;
                Console.Write("*");
                for (int line = 0; line < endLines ; line++)
                {
                    Console.Write("-");
                }
                endLines --;
                Console.WriteLine();
            }
            //last line
            for (int line = 0; line < lineCount; line++)
            {
                Console.Write("-");
            }
            lineCount--;
            Console.Write("*");
            for (int star = 0; star < innerLines - 1; star++)
            {
                Console.Write("*");
            }
            innerLines += 2;
            Console.Write("*");
            for (int line = 0; line < endLines; line++)
            {
                Console.Write("-");
            }
            endLines--;
            Console.WriteLine();
            Console.WriteLine();
            
        }
    }
}
