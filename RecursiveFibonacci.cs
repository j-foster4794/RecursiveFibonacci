using System;
using System.Reflection.Emit;
using System.Xml.XPath;

namespace RecursiveFibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What number of the fibonacci sequence do you want?");
            int position = Convert.ToInt32(Console.ReadLine());
            int result = fib(position);
            System.Console.WriteLine("Position " + position + " is " + result + ".");
        }

        static int fib(int x){
            if (x == 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return fib(x-1) + fib(x-2);
            }
        }
    }
}