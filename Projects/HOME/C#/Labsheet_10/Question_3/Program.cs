using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks:");
            Console.Write("--> ");
            int mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Grade: {0}", Grade(mark));

            Console.Read();
        }

        private static char Grade(int x)
        {
            char grade = ' ';
            int temp = x / 10;
            switch(temp)
            {
                case 10:
                case 9:
                case 8:
                    grade = 'A';
                    break;
                case 7:
                case 6:
                    grade = 'B';
                    break;
                case 5:
                case 4:
                    grade = 'C';
                    break;
                case 3:
                case 2:
                case 1:
                case 0:
                    grade = 'D';
                    break;
            }
            return grade;
        }
    }
}
