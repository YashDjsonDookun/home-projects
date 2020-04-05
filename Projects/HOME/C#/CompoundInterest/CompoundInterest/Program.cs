/*
 * StudentID: 1810111
 * StudentName: Yash Djson Dookun
 * Task: 4.	Write a program which finds out the value of a bank deposit, P, 
 *          after n years given that the annual interest on the deposit is r %, assuming that no 
 *          withdrawals are made during those n years. P, n and r are to be input by the user. 
 *          The program must display the value of the bank deposit after each year in an appropriate
 *          format.
 *          Note that this problem involves the calculation of compound interest.
 */
using System;

namespace CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 0;

            Console.WriteLine("Enter Principal, P($):");
            Console.Write("--> ");
            double P = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter annual interest rate, r(%):");
            Console.Write("--> ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of years, n(years):");
            Console.Write("--> ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\nTreating Compound: YEARLY...\n\n");

            int i = 1;
            do
            {
                amount = P * ((Math.Pow(1 + (r / 100) / 1, (i))));
                Console.WriteLine("Value of bank deposit for year {0} is ${1}", i, amount);
                i++;
            } while (i < n+1);
            Console.Read();
        }
    }
}
