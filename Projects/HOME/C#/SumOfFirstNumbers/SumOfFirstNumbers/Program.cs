/*
 * Author: Yash Djson Dookun
 * Task: Write a c# program that calculates the sum of the first n numers
 *       i.e, 1+2+3+...+n
 */
using System;

namespace SumOfFirstNumbers
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
            while (i <= n)
            {
                Console.WriteLine("Sum = {0} + {1}", i, sum);
                sum += i;
                i++;
            }
            Console.WriteLine("\nTotal: {0}", sum);
            Console.Read();
        }
    }
}
