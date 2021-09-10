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
        static void sampleFn()
        {
            byte b1 = 45;
            sbyte b2 = 23;
            //b1 = b2 as byte;



            object obj = new object();
            User user1 = new User();
            obj = user1;
            Console.WriteLine(typeof(User));
            Console.WriteLine(user1 is User);
            Console.readLine();
        }

        public int age { get; } = 10; //data encapsulation
        float balance = 10.4F;
        //dynamic datatypes
        dynamic randomData = 10;
        Console.WriteLine(randomData is int);
        randomData = "Niranjan";
        Console.WriteLine(randomData is string);

        var name = "Welcome";
        var a = 34;
        Console.Wr




    }

}