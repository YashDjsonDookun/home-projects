/*
 * StudentName: Yash Djson Dookun
 * Task: Two points in a plane are specified using the coordinates (x1, y1) and (x2, y2). Write a program that accepts the inputs x1, y1, x2 & y2 and 
 *       (i)	calculates the slope of a line through two non-vertical points entered by the user using m = (y2 – y1)/(x2 – x1), and,
 *       (ii)	determines the distance between them; d = √((x2 – x1)2 + (y2 – y1)2)
 *       Note: Math.pow(a,b) is for ab and Math.sqrt(value) for square root.
*/
using System;

namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array of 2 index to represent coordinates (x1,y1), (x2,y2)
            double[] Coord1 = new double[2];
            double[] Coord2 = new double[2];

            Console.WriteLine("Enter X1: ");
            Console.Write("--> ");
            Coord1[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1: ");
            Console.Write("--> ");
            Coord1[1] = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2: ");
            Console.Write("--> ");
            Coord2[0] = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2: ");
            Console.Write("--> ");
            Coord2[1] = double.Parse(Console.ReadLine());
            //Method to find the slope of the line
            FindGradient(Coord1, Coord2);
            //Method to find the distance between the 2 coordinates
            FindDistance(Coord1, Coord2);
        }

        static void FindGradient(double[] Arr1, double[] Arr2) {
            // gradient,m = (y2 – y1)/(x2 – x1)
            double gradient = (Arr2[1] - Arr1[1])/(Arr2[0] - Arr1[0]);
            Console.WriteLine("Slope of the line: {0}", gradient);
        }

        static void FindDistance(double[] Arr1, double[] Arr2) {
            // distance,d = √((x2 – x1)2 + (y2 – y1)2)
            double distance = Math.Sqrt(Math.Pow((Arr2[0] - Arr1[0]),2)+Math.Pow((Arr2[1] - Arr1[1]),2));
            Console.WriteLine("Distance between the 2 Coordinates: {0} units.", distance);
        }
    }
}
