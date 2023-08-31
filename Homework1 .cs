using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining variables and equation
            double X = 2.5;
            double Y = 3.3;
            double Z = 4 * X * X + 3 * Y;

            //printing output
            Console.WriteLine($"X = {X}, Y={Y}");
            Console.WriteLine($"Thevalue of Z is:{Z}");
        }
    }
}