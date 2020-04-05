using System;

namespace Question_1_b
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

            Area(length, width);
            Perimeter(length, width);
            Console.Read();
        }

        private static void Area(double x, double y)
        {
            double area = x * y;
            Console.WriteLine("The Area of the Rectangle is {0}.",area);
        }

        private static void Perimeter(double x, double y)
        {
            double perimeter = ((2 * x) + (2 * y));
            Console.WriteLine("The Perimeter of the Rectangle is {0}.", perimeter);
        }
    }
}
