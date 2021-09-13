using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_Polymorphism
{   
    class Calculator
    {
        public int num1, num2;
        
        public Calculator(int v1, int v2)
        {
            num1 = v1;
            num2 = v2;
        }
        public static Calculator operator -(Calculator c1)  
        {  //This fn is called and overrides the default '-'
          //Making a custom function for each operator 
            c1.num1 = -c1.num1;
            c1.num2 = -c1.num2;
            return c1;
        }
        public void print()
        {
            Console.WriteLine(num1.ToString()+ " , " + num2.ToString());
        }
    }
    class Operator_Overload
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(15, 25);
            calc = -calc; //calls our custom operator fn (and Overrides the defualt '-' opration)
            calc.print();

            Console.WriteLine("Press a key ...");
            Console.ReadLine();

        }
    }
}
