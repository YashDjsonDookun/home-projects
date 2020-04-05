/*
 * Author: Yash Djson Dookun
 * Task: Write a C# program that reads 3 numbers and displays the value of the largest number 
 */
using System;

namespace LargestOfThree
{
    class Program
    {
        static double num1;
        static double num2;
        static double num3;
        static void Main(string[] args)
        {
            Console.Write("Input Num1: ");
            string inputNum1 = Console.ReadLine();
            Console.Write("Input Num2: ");
            string inputNum2 = Console.ReadLine();
            Console.Write("Input Num3: ");
            string InputNum3 = Console.ReadLine();

            convertToDouble(inputNum1, inputNum2, InputNum3);
            findLargest(num1, num2, num3);
            Console.Read();
        }

        public static void convertToDouble(string x,string y,string z)
        {
            num1 = double.Parse(x);
            num2 = double.Parse(y);
            num3 = double.Parse(z);
        }

        public static void findLargest(double x, double y, double z)
        {
            if (x.Equals(y) && x.Equals(z))
            {
                Console.WriteLine("All 3 numbers are the same!!");
            }
            else if (x > y && x > z)
            {
                Console.WriteLine("The Largest Number of the 3 is: {0}", x);
            }
            else if (x < y && y > z)
            {
                Console.WriteLine("The Largest Number of the 3 is: {0}", y);
            }
            else if (x.Equals(y) && x.Equals(z) || y.Equals(x) && y.Equals(z) || z.Equals(x) && z.Equals(y))
            {
                Console.WriteLine("There are 2 identical numbers");
            }
            else
            {
                Console.WriteLine("The Largest Number of the 3 is: {0}", z);
            }
        }
    }
}
