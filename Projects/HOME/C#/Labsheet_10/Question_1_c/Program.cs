using System;

namespace Question_1_c
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
            
            Console.WriteLine("The Area of the Rectangle is {0}.", AreaOfRectangle(length, width));
            Console.WriteLine("The Perimeter of the Rectangle is {0}.", PerimeterOfRectangle(length, width));

            Console.Read();
        }

        private static double AreaOfRectangle(double x, double y)
        {
            double area = x * y;
            return area;
        }

        private static double PerimeterOfRectangle(double x, double y)
        {
            double perimeter = ((2 * x) + (2 * y));
            return perimeter;
        }
    }
}
