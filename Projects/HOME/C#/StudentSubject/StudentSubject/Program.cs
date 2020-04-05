/*
 * Author: Yash Djson Dookun
 * Task: A program that uses nested loops to read the marks of 5 students in 3 subjects and calculate
 *       their total marks and average. Note: For each student, the system must calculate and display
 *       the total and average.
 */
using System;

namespace StudentSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i < 6; i++)
            {
                double sum = 0;
                Console.WriteLine("Student {0}", i);
                Console.WriteLine("-----------");
                for (int j=1; j < 4; j++)
                {
                    Console.WriteLine("Enter marks for subject {0}: ",j);
                    Console.Write("--> ");
                    double marks = double.Parse(Console.ReadLine());
                    
                    sum += marks;
                }
                double average = 0;
                average = sum / 3;
                Console.WriteLine("Total: {0},\nAverage: {1}\n", sum, average);
            }
            Console.Read();
        }
    }
}
