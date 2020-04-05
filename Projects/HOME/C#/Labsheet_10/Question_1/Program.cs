using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Length: ");
            Console.Write("--> ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Width: ");
            Console.Write("--> ");
            double width = double.Parse(Console.ReadLine());

            Computation(length, width);
            Console.Read();
        }
        private static void Computation(double x, double y)
        {
            double area = x * y;
            double perimeter = ((2 * x) + (2 * y));
            Console.WriteLine("The Area of the Rectangle is {0}.\nThe Perimeter of the Rectangle is {1}.", area, perimeter);
        }
    }
}
