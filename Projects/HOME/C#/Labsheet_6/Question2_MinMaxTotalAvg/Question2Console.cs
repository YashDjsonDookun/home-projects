using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_MinMaxTotalAvg
{
    class Question2Console
    {
        static double num1;
        static double num2;
        static double num3;
        static double largest;
        static double smallest;
        static double sumMaxMin;
        static double sum;
        static void Main(string[] args)
        {
            AllowInputs();
            findLargest(num1, num2, num3);
            findSmallest(num1, num2, num3);
            Sum(num1, num2, num3);
            Average(sum, sumMaxMin);
            Console.Read();
        }
        public static void AllowInputs()
        {
            Console.Write("Input Num1: ");
            string inputNum1 = Console.ReadLine();
            Console.Write("Input Num2: ");
            string inputNum2 = Console.ReadLine();
            Console.Write("Input Num3: ");
            string InputNum3 = Console.ReadLine();
            Console.WriteLine();
            convertToDouble(inputNum1, inputNum2, InputNum3);
        }

        public static void convertToDouble(string x, string y, string z)
        {
            num1 = double.Parse(x);
            num2 = double.Parse(y);
            num3 = double.Parse(z);
        }
        public static double findLargest(double x, double y, double z)
        {
            if (x.Equals(y) && x.Equals(z))
            {
                Console.WriteLine("All 3 numbers are the same!!");
            }
            else if (x > y && x > z)
            {
                largest = x;
            }
            else if (x < y && y > z)
            {
                largest = y;
            }
            else if (x.Equals(y) && x.Equals(z) || y.Equals(x) && y.Equals(z) || z.Equals(x) && z.Equals(y))
            {
                Console.WriteLine("There are 2 identical numbers");
            }
            else
            {
                largest = z;
            }
            Console.WriteLine("Maximum: {0}", largest);
            return largest;
        }
        public static double findSmallest(double x, double y, double z)
        {
            if (x.Equals(y) && x.Equals(z))
            {
                Console.WriteLine("All 3 numbers are the same!!");
            }
            else if (x < y && x < z)
            {
                smallest = x;
            }
            else if (x > y && y < z)
            {
                smallest = y;
            }
            else if (x.Equals(y) && x.Equals(z) || y.Equals(x) && y.Equals(z) || z.Equals(x) && z.Equals(y))
            {
                Console.WriteLine("There are 2 identical numbers");
            }
            else
            {
                smallest = z;
            }
            Console.WriteLine("Minimum: {0}", smallest);
            return smallest;
        }

        public static void Sum(double x, double y, double z)
        {
            sum = x + y + z;
            Console.WriteLine("Total of all 3 numbers: {0}", sum);
            sumMaxMin = smallest + largest;
            Console.WriteLine("Total of Minimum and Maximum: {0}", sumMaxMin);
        }
        public static void Average(double x, double y)
        {
            double average = x / 3;
            Console.WriteLine("Average of all 3 numbers: {0}", average);

            double averageMinMax = y / 2;
            Console.WriteLine("Average of Minimum and Maximum: {0}", averageMinMax);
        }
    }
}
