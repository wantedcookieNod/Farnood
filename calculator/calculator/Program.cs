using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,e; double pvresualt;
            double Result=0;
            string c, x ;
            Console.WriteLine("Welcome");
            Console.WriteLine("The program helps you to calculate your numbers,");
        start:;
            Console.WriteLine("Enter your numbers..?");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" +  -  *  / ");
            c = Console.ReadLine();
            Console.WriteLine("Enter your next numbers..?");
            b = Convert.ToDouble(Console.ReadLine());
            switch (c)
            {
                case "+":
                    Result = a + b;
                    break;
                case "-":
                    Result = a - b;
                    break;
                case "*":
                    Result = a * b;
                    break;
                case "/":
                    Result = a / b;
                    break;
                default:
                    Console.WriteLine("something went wrong please try again");
                    break;
            }
            Console.WriteLine(" = " + Result);
            Console.WriteLine("Press any key to continue Or press 'X' to Exit, press 'C' to reset the numbers...");
            x = Console.ReadLine();
            if (x == "c")
                goto start;
            else if (x == "x")
            {
                goto exit;
            }
        SecondCycle:;
            Console.WriteLine("Enter your next numbers..?");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" +  -  *  / ");
            c = Console.ReadLine();

            switch (c)
            {
                case "+":
                    Result = e + Result;
                    break;
                case "-":
                    Result = e - Result;
                    break;
                case "*":
                    Result = e * Result;
                    break;
                case "/":
                    Result = e / Result;
                    break;
                default:
                    Console.WriteLine("something went wrong please try again");
                    break;
            }
            Console.WriteLine(" = " + Result);
            Console.WriteLine("Enter your next numbers..Or press 'X' to Exit, press 'C' to reset the numbers...");
            x = Console.ReadLine();
            if (x == "c")
                goto start;
            else if (x == "x")
            {
                goto exit;
            }
            else
                goto SecondCycle;
            





    exit:;
            Console.WriteLine("thank you for using this program");

        }
    }
}
