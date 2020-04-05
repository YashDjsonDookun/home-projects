using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a user Login System, where the user can first register and then Login in. The Program should check if the user has entered the correct username and password, when login in (so the same ones that he used when registering).
 * As we haven't covered storing data yet, just create the program in a way, that registering and logging in, happen in the same execution of it.
 * User If statements and User Input and Methods to solve the challenge.
 */

namespace ChallengeLogin
{
    class Program
    {
        public static string storedUsername;
        public static string storedPassword;
        public static string Username;
        public static string Password;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this crappy Login System\nPlease Register your username & password\n");
            Register();
            Console.Read();
        }

        public static void Register()
        {
            Console.Write("Username: ");
            storedUsername = Console.ReadLine();
            Console.Write("Password: ");
            storedPassword = Console.ReadLine();

            SuccessfulRegistration();
            Login();
        }

        public static void Login()
        {
            Console.Write("Username: ");
            Username = Console.ReadLine();
            Console.Write("Password: ");
            Password = Console.ReadLine();
            ValidateEntry();
        }

        public static void ValidateEntry()
        {
            if ((Username.Equals(storedUsername)))
            {
                if ((Password.Equals(storedPassword)))
                {
                    SuccessfulLogin();
                }
                else
                {
                    Console.WriteLine("Incorrect Password!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Username!");
            }
        }
        public static void SuccessfulLogin()
        {
            Console.WriteLine("Congratulations!! You've Logged in!");
            Console.WriteLine("Press any key to Log Out!");
        }
        public static void SuccessfulRegistration()
        {
            Console.WriteLine("Successfully Registered\n---------------------------------------------------\n");
        }
    }
}
