using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathapp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {

           
            double num1 = 15.6;
            double num2 = -8.3;
            double num3 = 4;
            double num4 = 50;
            double num5 = 9;

       
            double absVal = Math.Abs(num2);
            double powerVal = Math.Pow(num3, 2);
            double sqrtVal = Math.Sqrt(num4);
            double highest = Math.Max(num1, num5);
            double lowest = Math.Min(num1, num5);
            double rounded = Math.Round(num1);

            Console.WriteLine("Abs of num2: " + absVal);
            Console.WriteLine("num3 squared: " + powerVal);
            Console.WriteLine("Square root of num4: " + sqrtVal);
            Console.WriteLine("Higher between num1 and num5: " + highest);
            Console.WriteLine("Lower between num1 and num5: " + lowest);
            Console.WriteLine("Rounded num1: " + rounded);



        }
    }
}
