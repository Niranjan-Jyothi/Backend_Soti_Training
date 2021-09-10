using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = getUserInput();
            int b = getUserInput();
            Console.WriteLine($"SUM of both the numbers = {sum(a,b)}");

            Console.ReadLine();
        }

        private static int sum(int a, int b)
        {
            return a + b;
        }

        private static int getUserInput()
        {
            Console.Write("Enter a Number -> ");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
