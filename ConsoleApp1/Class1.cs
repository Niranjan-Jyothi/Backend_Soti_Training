using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public string name { get; set; }
    }

    public class Day2Class
    {
        public void sampleFn()
        {
            Console.WriteLine("Inside External Class");

            byte b1 = 45;
            sbyte b2 = 23;
            //b1 = b2 as byte;



            object obj = new object();
            User user1 = new User();
            obj = user1;
            Console.WriteLine(typeof(User));
            Console.WriteLine(user1 is User);
            

            float balance = 10.4F; //Using FLoat type for balance for space efficency in practical cases

            //dynamic datatypes
            dynamic randomData = 10;
            Console.WriteLine(randomData is int);

            randomData = "Niranjan";
            Console.WriteLine(randomData is string);



            var name = "Welcome";
            var a = 34;
            //name = 20;  -- Error, because var types are static
        }

        public byte age { get; } = 10; //data encapsulation
        

        
    }


   
 }  

