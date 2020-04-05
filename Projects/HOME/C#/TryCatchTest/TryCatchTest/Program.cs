using System;

namespace TryCatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }
        public static void Calculate()
        {
            try
            {
                Console.Write("Please enter 1st digit: ");
                string num1 = Console.ReadLine();
                Console.Write("Please enter 2nd digit: ");
                string num2 = Console.ReadLine();

                ConvertToInt1(num1);
                ConvertToInt2(num2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception, please enter the correct type next time!"+ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("OverFlow exception, the number ws too long or too short for an int32" + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)" + ex.Message);
            }
            finally
            {
                int result = (number1 + number2);
                Console.WriteLine("The Sum of the 2 numbers is: {0}", result);
                Console.ReadKey();
            }
        }
        public static int number1;
        public static int number2;
        public static int ConvertToInt1(string x)
        {
            number1 = int.Parse(x);
            return number1;
        }
        public static int ConvertToInt2(string y)
        {
            number2 = int.Parse(y);
            return number2;
        }
    }
}
