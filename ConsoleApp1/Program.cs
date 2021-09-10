using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20, j = 2000;

            //studying_ifElse(i, j);
           // studying_switch(i);
            //studying_for_loop();
           // priniting_star_patter(5);
            
            //DAY - 2
           // ArrayDemo();
            takeInputFromConsole();
            Console.ReadLine();
            
        }

        private static void takeInputFromConsole()
        {
            Console.Write("Type in anything and press Enter  ---> ");
            String userInput = Console.ReadLine();
            Console.WriteLine(userInput);
           // convertedInput = Convert.
        }

        static void ArrayDemo()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };

            var a = from i in array1 where i % 2 == 0 select i;

            foreach (var _a in a)
            {
                Console.WriteLine($"{_a}");
            }

            Console.ReadLine();
        }

        static bool isGreater(int i, int j)
        {
            return i > j;
        }

        static void studying_ifElse(int i, int j)
        {
            if (isGreater(i, j))
            {
                Console.WriteLine("i is Greater than j");
            }
            else if (isGreater(j, i))
            {
                Console.WriteLine("j is greater than i");
            }

            else
            {
                Console.WriteLine("i is equal to j");

            }
        }
        static void studying_switch(int x)
        {
            switch (x)
            {
                case 5:
                    Console.WriteLine("Number is 5");
                    break;

                case 10:
                    Console.WriteLine("Number is 10");
                    break;

                case 20:
                case 30:
                    Console.WriteLine("Number Might be 20 or 30, so dynamically printing the Number..");
                    Console.WriteLine($"Number eqauls {x}");
                    break;

                default:
                    Console.WriteLine("Unknown value");
                    break;
            }
        }

        static void studying_for_loop()
        {
            for(double d=1.01; d<1.1; d+=0.01)
            {
                Console.WriteLine($"Value of d is {d}");
            }

            for (int i=0, j=0; i+j <5; i++, j++)
            {
                Console.WriteLine($"Value of i: {i} , j: {j}");
            }
        }

        static void priniting_star_patter(int rows)
        {
            int col = 1;
            for(int i=rows; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    if (i==rows || i>=j || j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
