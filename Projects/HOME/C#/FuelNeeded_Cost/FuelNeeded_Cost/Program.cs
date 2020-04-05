/*
 * Author: Yash Djson Dookun
 * StudentID: 
 * Task: A system that asks a user to enter the distance of a trip in km,
 *       the km per litre estimate for the user’s car, and the average cost
 *       of a litre of fuel and then calculates and displays the number of
 *       litres of fuel needed and the estimated cost of the trip.
 */
using System;

namespace FuelNeeded_Cost
{
    class Program
    {
        static double distance;
        static double estimatedDistance;
        static double costPerLiter;
        static double numberOfLitersRequired;
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance of trip in Km: ");
            Console.Write("--> ");
            distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Input Kilometer per litre estimate (in Km): ");
            Console.Write("--> ");
            estimatedDistance = double.Parse(Console.ReadLine());

            Console.WriteLine("Input cost per litre: ");
            Console.Write("--> ");
            costPerLiter = double.Parse(Console.ReadLine());

            CalculateLitres(distance, estimatedDistance);
            CalculateCost(costPerLiter, numberOfLitersRequired);
            Console.Read();
        }

        public static double CalculateLitres(double x, double y)
        {
            //estimatedDistance / distance
            numberOfLitersRequired = (x / y);
            Console.WriteLine("Number of litres required for {0} Km = {1}L", x, numberOfLitersRequired);
            return numberOfLitersRequired;
        }

        public static void CalculateCost(double x, double y)
        {
            double cost = x * y;
            Console.WriteLine("The estimated cost for the {0}Km trip is ${1}", distance, cost);
        }
    }
}
