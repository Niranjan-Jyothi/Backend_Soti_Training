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

            generalConcepts gc = new generalConcepts();
            //generalConcepts.tryParsing();  ----You CAN'T call another class STATIC Methods using its instance, insetead use the class name itself
            // gc.unboxing();  --- You CAN'T call another class STATIC Methods using its instance, insetead use the class name itself
            //gc.assignment1_fn();
            //gc.studyingArray();

            string[] arr1 = { "bird", "cat" ,"alphie", "bird2", "bird", "sample Text"};
            string[] arr2 = { "bird", "dog" };
            
            //gc.combine_without_duplicates(arr1, arr2);
            //gc.sortArr(arr1);
            //gc.countElements(arr1);
            //gc.joinArray(arr1);
            //gc.removeDuplicates(arr1);
            gc.find_All_Elements_With_Length_Greater_Than(arr1, 5);

            Console.WriteLine("Press any Key to exit Program ....");
            Console.ReadLine();
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
