/*
 * Author: Yash Djson Dookun
 * Task: Write a C# program that calculates the sum of the first odd numbers till n
 */
using System;

namespace SumOfFirstOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of n");
            Console.Write("--> ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int i = 1;
            Console.WriteLine("Sum=0\ni=1\nSum = Sum + i");

            while (i <= n)
            {
                Console.WriteLine("(New Sum){0} = (Sum){0} + (i){1}", sum, i);
                sum += i;
                i = i + 2;
            }
            Console.WriteLine("\nTotal: {0}", sum);
            Console.Read();
        }
    }
}
