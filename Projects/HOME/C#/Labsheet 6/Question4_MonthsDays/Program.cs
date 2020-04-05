using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4_MonthsDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input here");
            Console.Write("--> ");
            int month = int.Parse(Console.ReadLine());

            CheckForDay(month);
            Console.Read();
        }

        public static void CheckForDay(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine("January has 31 days.");
                    break;
                case 2:
                    Console.WriteLine("February has 28/29 days.");
                    break;
                case 3:
                    Console.WriteLine("March has 31 days.");
                    break;
                case 4:
                    Console.WriteLine("April has 30 days.");
                    break;
                case 5:
                    Console.WriteLine("May has 31 days.");
                    break;
                case 6:
                    Console.WriteLine("June has 30 days.");
                    break;
                case 7:
                    Console.WriteLine("July has 31 days.");
                    break;
                case 8:
                    Console.WriteLine("August has 31 days.");
                    break;
                case 9:
                    Console.WriteLine("September has 30 days.");
                    break;
                case 10:
                    Console.WriteLine("October has 31 days.");
                    break;
                case 11:
                    Console.WriteLine("November has 30 days.");
                    break;
                case 12:
                    Console.WriteLine("December has 31 days.");
                    break;
                default:
                    Console.WriteLine("Input only an integer in the range of 1-12");
                    break;
            }
        }
    }
}
