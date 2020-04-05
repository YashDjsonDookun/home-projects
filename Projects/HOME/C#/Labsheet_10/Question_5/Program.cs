using System;


namespace Question_5
{
    class Program
    {
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

            Compute(inputNum1, inputNum2, inputNum3);

            Console.Read();
        }

        private static void Compute(int x, int y, int z)
        {
            int maximum = Math.Max(x, Math.Max(y, z));
            int minimum = Math.Min(x, Math.Min(y, z));
            int sum = x + y + z;
            double average = sum / 3;
            Console.WriteLine("" +
                "Maximum: {0}.\n" +
                "Minimum: {1}.\n" +
                "Sum: {2}.\n" +
                "Average: {3}.", maximum, minimum, sum, average);
        }
    }
}
