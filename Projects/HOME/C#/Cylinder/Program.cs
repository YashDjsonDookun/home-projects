/*
 * StudentName: Yash Djson Dookun
 * Task: Write a C# program that prompts the user for the radius and height of a closed cylinder and
 *       calculates and displays the volume and total surface area of the cylinder
*/
using System;

namespace Cylinder
{
    class Program
    {
        const double pi = Math.PI;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius, r (in m):");
            Console.Write("--> ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height, h (in m):");
            Console.Write("--> ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Volume of Cylinder: {0:0.##}m3.", CalculateVolume(r,h));
            Console.WriteLine("Total Surface Area of Cylinder: {0:0.##}m2.", CalculateTSA(r,h));
        }

        static double CalculateVolume(double x, double y)
        {
            double v = (pi * Math.Pow(x,2) * y);
            return v;
        }

        static double CalculateTSA(double x, double y)
        {
            double TSA = ((2*pi*x)*(y+x));
            return TSA;
        }
    }
}
