/* 
 * Author: Yash Djson Dookun
 * Task  : Create a C# program to convert the distance in miles to
 *         Kilometers where 1 mile = 1.609km
 */
using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance in Miles:");
            Console.Write("--> ");
            double miles = double.Parse(Console.ReadLine());

            const double conversion = 1.609;

            double kilometers = (miles * conversion);

            Console.WriteLine("{0} mile(s) = {1} kilometers.", miles, kilometers);
            Console.Read();
        }
    }
}
