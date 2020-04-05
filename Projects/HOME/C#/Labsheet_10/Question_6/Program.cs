using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Hours Worked: ");
            Console.Write("--> ");
            double numberOfHoursWorked = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hourly Pay-Rate: ");
            Console.Write("--> ");
            double hourlyPayRate = double.Parse(Console.ReadLine());

            Console.WriteLine(CalcGrossPay(numberOfHoursWorked, hourlyPayRate).ToString());

            Console.Read();
        }

        private static double CalcGrossPay(double num, double rate)
        {
            double grossPay = 0;
            if (num <= 40)
            {
                grossPay = num * rate;
            }
            else
            {
                grossPay = ((40 * rate) + ((num - 40) * (1.5 * rate)));
            }
            return grossPay;
        }
    }
}
