using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of Subjects: ");
            int numberOfSubjects = int.Parse(Console.ReadLine());

            int[,] marks = new int[numberOfStudents, numberOfSubjects];
            Console.WriteLine();

            for (int i=0; i<numberOfStudents; i++)
            {
                Console.WriteLine("Entering marks for Student {0}...", i+1);
                for (int j=0; j < numberOfSubjects; j++)
                {
                    Console.Write("Enter marks for Subject {0}: ", j+1);

                    marks[i,j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("Displaying the contents of the 2D Array...");
            for (int i=0; i < numberOfStudents; i++)
            {
                for (int j=0; j < numberOfSubjects; j++)
                {
                    Console.Write(marks[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < numberOfStudents; i++)
            {
                int min = marks[i, 0];
                int max = marks[i, 0];
                double average;
                int total =0;

                Console.WriteLine("Processed Marks for Student {0}...", i + 1);
                for (int j = 0; j < numberOfSubjects; j++)
                {
                    if (min >= marks[i, j])
                    {
                        min = marks[i, j];
                    }

                    if (max <= marks[i, j])
                    {
                        max = marks[i, j];
                    }
                    total += marks[i, j];
                }
                average = (total / numberOfSubjects);
                Console.WriteLine("min: " + min);
                Console.WriteLine("Max: " + max);
                Console.WriteLine("Total: " + total);
                Console.WriteLine("Avg: " + average);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
