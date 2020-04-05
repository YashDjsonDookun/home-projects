/*
 * Author: Yash Djson Dookun
 * Task:	A system that displays the corresponding grade according to the following grading scheme:
            Score < 40	F
            40 <= score < 50	D
            50 <= score < 60	C
            60 <= score < 70	B
            score >= 70	A

 */
using System;

namespace GradeScheme
{
    class Program
    {
        static char grade;
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*   Score < 40        *  F  *");
            Console.WriteLine("*****************************");
            Console.WriteLine("*   40 <= score < 50  *  D  *");
            Console.WriteLine("*****************************");
            Console.WriteLine("*   50 <= score < 60  *  C  *");
            Console.WriteLine("*****************************");
            Console.WriteLine("*   60 <= score < 70  *  B  *");
            Console.WriteLine("*****************************");
            Console.WriteLine("*   score >= 70       *  A  *");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("Enter marks: ");
            Console.Write("--> ");
            string inputMark = Console.ReadLine();
            double mark = double.Parse(inputMark);
            try
            {
                CheckGrade(mark);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }

        public static void CheckGrade(double x)
        {
            do
            {
                if (x < 40)
                {
                    grade = 'F';
                }
                else if (x > 39 && x < 50)
                {
                    grade = 'D';
                }
                else if (x > 49 && x < 60)
                {
                    grade = 'C';
                }
                else if (x > 59 && x < 70)
                {
                    grade = 'B';
                }
                else
                {
                    grade = 'A';
                }
                Console.WriteLine("Grade: {0}", grade);
                break;      
            } while (true);
        }
    }
}
