/*
 * StudentID:
 * StudentName: Yash Djson Dookun
 * Task: 6.	A program that prompts the user to enter the correct password (application development).
 *          A corresponding message should then be displayed (whether or not the password has been correctly entered). 
 *          The system should give the user only three chances to enter the correct password.
 * 
 */
using System;

namespace PasswordChecker
{
    class Program
    {
        static string enteredPassword;
        static void Main(string[] args)
        {
            Console.Write("Set Original Password: ");
            string original = Console.ReadLine();

            Console.WriteLine("\n\n\n\n");
            
            int i = 0;
            do
            {
                Console.Write("\nEnter password : ");
                enteredPassword = Console.ReadLine();

                if (enteredPassword == original)
                {
                    Console.WriteLine("\nPassword Entered Correctly!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nPassword Entered Incorrectly!");
                    i++;
                }
                
                if (i == 3)
                {
                    Console.WriteLine("\n3 Bad attempts!");
                    break;
                }
            } while (i < 3);
            Console.Read();
        }
    }
}
