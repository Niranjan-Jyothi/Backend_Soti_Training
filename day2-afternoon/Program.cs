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

            //Calculator();
            //tryParsing();
            //unboxing();
            Console.WriteLine(assignment1_fn(4));

            Console.ReadLine();
        }

        
        private static int assignment1_fn(int y)
        {
            
            int x = (int)(Math.Pow(y, 2) + (2 * y) + 1);
            return x;
        }

        private static void unboxing()
        {
            Object Myobj = 30;
            int i = (int)Myobj; //Need Explit Conv because we are converting a Ref Type (object) to a Value Type (int)..For the reverse case, its not needed.
            Console.WriteLine(i);

        }

        private static void tryParsing()
        {
            string val = "21";
            int result;
            bool ifSuccess = int.TryParse(val, out result);
            Console.WriteLine(result);

            Console.WriteLine(ifSuccess);

            string val2 = "101.11";
            int result2;
            bool ifSuccess2 = int.TryParse(val2, out result2);

            Console.WriteLine(ifSuccess2);
        }
        private static void Calculator()
        {
            int a = getUserInput();
            int b = getUserInput();
            Console.WriteLine($"SUM of both the numbers = {sum(a,b)}");
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
