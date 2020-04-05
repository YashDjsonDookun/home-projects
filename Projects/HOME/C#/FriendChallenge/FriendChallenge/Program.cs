using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*In this challenge you will deepen your understanding for methods.
 *Please go ahead and create three variables with names of your friends.
 *Then create a Method "GreetFriend" which writes something like: "Hi Frank, my friend!" onto the console, once it is called.
 *Where "Frank" should be replaced with the Name behind the argument given to the Method when it's called. So the method will need a parameter (decide which DataType will be best). 
 *
 *Greet all your three friends.
 */

namespace FriendChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            const string friend1 = "Tom";
            const string friend2 = "Dick";
            const string friend3 = "Harry";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

            Console.Read();
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hi {0}, my friend!", name);
        }
    }
}
