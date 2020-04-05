/*
 * StudentID:
 * StudentName: Yash Djson Dookun
 * Task: 5.	A program that prompts the user to enter the number of subjects 
 *          she/he wants to manipulate and your program should calculate the 
 *          minimum mark, the maximum mark and the average mark. 
 *          
 *          E.g. if the user enters 5 as the number of subjects, he is then prompted 
 *          to enter the 5 marks and the system calculates and displays the min, max, 
 *          total and average marks.
 */
using System;

namespace StudentMarkings
{
    class Program
    {
        static double total = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Subjects:");
            Console.Write("--> ");
            int n = int.Parse(Console.ReadLine());

            double[] marks = new double[n];
            int i = 1;
            int j = 0;
            do
            {
                Console.WriteLine("Marks for subject {0}: ", i);
                Console.Write("--> ");
                marks[j] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
                j++;
            } while (i < n+1);

            findMinMax(marks);
            findTotal(marks);
            findAverage(n, total);
            Console.Read();
        }

        static double[] findMinMax(double[] a)
        {
            double t = 0;
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("\n\n\n");
            double minimum = a[0];
            double maximum = a[a.Length - 1];
            Console.WriteLine("Minimum:{0}\nMaximum:{1}", minimum, maximum);
            return a;
        }

        static double findTotal(double[] x)
        {
            for (int i=0; i < x.Length; i++)
            {
                total += x[i];
            }
            Console.WriteLine("Total: {0}", total);
            return total;
        }

        static void findAverage(int x, double y)
        {
            double average = y / x;
            Console.WriteLine("Average: {0}", average);
        }
    }
}
