using System;

namespace Question_5_b
{
    class Program
    {
        static int sum;
        static void Main(string[] args)
        {
            Console.WriteLine("Input Num1: ");
            Console.Write("--> ");
            int inputNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Num2: ");
            Console.Write("--> ");
            int inputNum2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Num3: ");
            Console.Write("--> ");
            int inputNum3 = int.Parse(Console.ReadLine());

            Maximum(inputNum1, inputNum2, inputNum3);
            Minimum(inputNum1, inputNum2, inputNum3);
            Sum(inputNum1, inputNum2, inputNum3);
            Average(sum);

            Console.Read();
        }

        private static void Maximum(int x, int y, int z)
        {
            int maximum = Math.Max(x, Math.Max(y, z));
            Console.WriteLine("Maximum: {0}",maximum);
        }

        private static void Minimum(int x, int y, int z)
        {
            int minimum = Math.Min(x, Math.Min(y, z));
            Console.WriteLine("Minimum: {0}", minimum);
        }

        private static int Sum(int x, int y, int z)
        {
            sum = x + y + z;
            Console.WriteLine("Sum: {0}", sum);
            return sum;
        }

        private static void Average(int x)
        {
            double average = x / 3;
            Console.WriteLine("Average: {0}", average);
        }
    }
}
