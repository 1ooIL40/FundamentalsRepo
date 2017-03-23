using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations.docx
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;
            try
            {
                numberOne = int.Parse(Console.ReadLine());
                numberTwo = int.Parse(Console.ReadLine());

                double result = 0;

                string simbol = Console.ReadLine();

                switch (simbol)
                {
                    case "-":
                      result =  numberOne - numberTwo;
                        break;
                    case "+":
                        result = numberOne + numberTwo;
                        break;
                    case "/":
                        if (numberTwo != 0)
                        {
                            result = (double)numberOne / numberTwo;
                        }
                        else
                        {
                            result = numberOne / numberTwo;
                        }
                        break;
                    case "*":
                        result = numberOne * numberTwo;
                        break;
                    case "%":
                        result = numberOne % numberTwo;
                        break;
                }
                
                if (simbol == "+" || simbol == "-" || simbol == "*")
                {
                    if(result % 2 == 0)
                    {
                        Console.WriteLine("{0} {1} {2} = {3} - even",numberOne, simbol, numberTwo, result);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} = {3} - odd", numberOne, simbol, numberTwo, result);
                    }
                }
                else if (simbol == "/")
                {
                    Console.WriteLine("{0} {1} {2} = {3:f2}", numberOne, simbol, numberTwo, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3}", numberOne, simbol, numberTwo, result);
                }


            }
            catch
            {
                Console.WriteLine("Cannot divide {0} by zero", numberOne);
            }
        }
    }
}
