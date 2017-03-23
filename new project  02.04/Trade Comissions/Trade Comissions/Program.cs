using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            if (sales > 0 && (city == "sofia" || city == "varna" || city == "plovdiv"))
            {
                if (sales >= 0 && sales <= 500)
                {
                    var sofia = 0.05;
                    var varna = 0.045;
                    var plovdiv = 0.055;
                    if (city == "sofia")
                    {
                        Console.WriteLine("{0:f2}", sales * sofia);
                    }
                    else if (city == "varna")
                    {
                        Console.WriteLine("{0:f2}", sales * varna);
                    }
                    else
                    {
                        Console.WriteLine("{0:f2}",sales * plovdiv);
                    }
                }
                else if (sales > 500 && sales <= 1000)
                {
                    var sofia = 0.07;
                    var varna = 0.075;
                    var plovdiv = 0.08;
                    if (city == "sofia")
                    {
                        Console.WriteLine("{0:f2}", sales * sofia);
                    }
                    else if (city == "varna")
                    {
                        Console.WriteLine("{0:f2}", sales * varna);
                    }
                    else
                    {
                        Console.WriteLine("{0:f2}", sales * plovdiv);
                    }
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    var sofia = 0.08;
                    var varna = 0.1;
                    var plovdiv = 0.12;
                    if (city == "sofia")
                    {
                        Console.WriteLine("{0:f2}", sales * sofia);
                    }
                    else if (city == "varna")
                    {
                        Console.WriteLine("{0:f2}", sales * varna);
                    }
                    else
                    {
                        Console.WriteLine("{0:f2}", sales * plovdiv);
                    }
                }
                else
                {
                    var sofia = 0.12;
                    var varna = 0.13;
                    var plovdiv = 0.145;
                    if (city == "sofia")
                    {
                        Console.WriteLine("{0:f2}", sales * sofia);
                    }
                    else if (city == "varna")
                    {
                        Console.WriteLine("{0:f2}", sales * varna);
                    }
                    else
                    {
                        Console.WriteLine("{0:f2}",(sales * plovdiv));
                    }
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
