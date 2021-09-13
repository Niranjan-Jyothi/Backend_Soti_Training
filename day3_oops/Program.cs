using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_oops
{   
    class Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public Shape()
        {
            Console.WriteLine("Inside constructor of Shape");
        }
    }

    class Triangle : Shape
    {
        string kind;
        static long dateOfCreation;

        static Triangle() //static constructor
        {
            dateOfCreation = DateTime.Now.Ticks; //Can only access static variables
            Console.WriteLine("Static Constructors are Only Called ONCE");
        }
        public Triangle( double v1, double v2): base() //parameterised constructor
        {
            width = v1;
            height = v2;
            
        }

        private Triangle(double area) //private constructor 
        { //- For Singleton Design patterns
        
        }
       

    }

    class Program
    {
        static void Main(string[] args)
        {
            basicsOfInheritence();
            Console.ReadLine();
        }

        private static void basicsOfInheritence()
        {
            new Shape(); //Only object created , Not Reference
            Triangle t1 = new Triangle(12.3, 34.0); //object, reference Both Created
            Triangle t2 = t1; //referring to same object
            Triangle t3 = new Triangle(27, 56);
            Console.WriteLine(t1 == t2);
        }
    }
}
