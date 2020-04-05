using System;

namespace maximumOfThree
{
    class Program
    {
        static double largest;
        static void Main(string[] args)
        {
            Console.Write("Input Num1: ");
            double inputNum1 = double.Parse(Console.ReadLine());
            Console.Write("Input Num2: ");
            double inputNum2 = double.Parse(Console.ReadLine());
            Console.Write("Input Num3: ");
            double InputNum3 = double.Parse(Console.ReadLine());

            DisplayMaximum(inputNum1, inputNum2, InputNum3);
            Console.Read();
        }
        public static void DisplayMaximum(double x, double y, double z)
        {
            largest = Math.Max(z,(Math.Max(x,y)));
            Console.WriteLine("\nThe maximum of {0}, {1} and {2} is: {3}.",x,y,z, largest);
        }
    }
}
