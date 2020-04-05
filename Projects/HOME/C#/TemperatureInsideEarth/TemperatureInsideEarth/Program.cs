/*
 * Author: Yash Djson Dookun
 * Task: Write a C# program that computes and displays the temperature inside the earth in
 *       Celcius ad Farenheit. The relevant formulae are:
 *                      Celsius = 10 * (depth) + 20
 *                      Farenheit = 1.8 * (Celsius) + 32
 */

using System;

namespace TemperatureInsideEarth
{
    class Program
    {
        static double celsius;
        static void Main(string[] args)
        {
            Console.WriteLine("Input depth in km");
            Console.Write("--> ");
            double depth = double.Parse(Console.ReadLine());

            CalculateCelsius(depth);
            ConvertToFarenheit(celsius);
            Console.Read();
        }
        public static double CalculateCelsius(double x)
        {
            celsius = 10 * (x) + 20;
            Console.WriteLine("Celsius: {0} degrees Celsius", celsius);
            return celsius;
        }

        public static void ConvertToFarenheit(double x)
        {
            double farenheit = (1.8 * (x) + 32);
            Console.WriteLine("Farenheit: {0} Farenheit", farenheit);
        }
    }
}
