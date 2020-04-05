using System;

namespace Question1
{
    class question1Console
    {
        static string enteredPassword;
        static int i = 3;
        static void Main(string[] args)
        {
            Console.WriteLine("You have " + i + " chances left");
            AskForPassword();
            CheckForPassword(enteredPassword);
            Console.Read();
        }

        public static void CheckForPassword(string x)
        {
            const string password = "visual";
            do
            {
                if (enteredPassword.Equals(password))
                {
                    Console.WriteLine("Welcome to the Application!");
                    Console.Write("Press any key to close the application.");
                    break;
                }
                else
                {
                    if (i != 1)
                    {
                        i--;
                        Console.WriteLine("You have " + i + " chance(s) left");
                        AskForPassword();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            } while (i > 0);
            
        }

        public static string AskForPassword()
        {
            Console.Write("--> ");
            enteredPassword = Console.ReadLine();
            return enteredPassword;
        }
    }
}
