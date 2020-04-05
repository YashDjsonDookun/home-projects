using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibNum(20).ToString());
            Console.ReadKey();
        }

        private static int FibNum(int fn)
        {
            if ((fn == 1) || (fn == 2))
            {
                return 1;
            }
                
            else
            {
                return FibNum(fn - 1) + FibNum(fn - 2);
            }
        }
    }
}
