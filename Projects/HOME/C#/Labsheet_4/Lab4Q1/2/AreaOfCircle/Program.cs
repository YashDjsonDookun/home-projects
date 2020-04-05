/*
 * Author: Yash Djson Dookun
 * Task: Write a C# Program to find the area of a circle
 */
using System;

namespace AreaOfCircle
{
    class Program
    {
        static double r;
        static double area;
        static void Main(string[] args)
        {
            Console.WriteLine("Input radius in cm: ");
            Console.Write("--> ");
            r = double.Parse(Console.ReadLine());

            CalculateArea(r);
            Console.Read();
        }

        public static void CalculateArea(double x)
        {
            const double pi = 3.14159265359;
            area = (pi * Math.Pow(x,2));
            Console.WriteLine("The Area of the circle is: {0} cm2.", area);
        }
    }
}

