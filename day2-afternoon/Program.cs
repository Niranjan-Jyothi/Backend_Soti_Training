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
            assignment1_fn();

            Console.WriteLine("Press any Key to exit Program ....");
            Console.ReadLine();
        }

        
        private static void assignment1_fn()
        {
            while (true)
            {
                string raw_userInp = Console.ReadLine();
                if (raw_userInp == "q")
                {
                    break;
                }
                int valid_userInp;
                bool ifSuccess = int.TryParse(raw_userInp, out valid_userInp);
                if (!ifSuccess)
                {
                    Console.WriteLine("Enter a Valid Integer");
                }
                else
                {
                    Console.WriteLine((int)(Math.Pow(valid_userInp, 2) + (2 * valid_userInp) + 1));
                }

            }
           
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
