using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_Polymorphism
{
    class RefandOutDemo
    {
        static int a1 = 0;

        public static void Main(string[] values)
        {

            //OutDemo();
            refDemo();

            Console.ReadLine();
        }

        private static void refDemo()
        {    //In case of ref the variable passed as ref MUST-BE initilised (unlike in case of Out)
            string str1 = "Initial name assigned to variable";
            SetValue(ref str1);
            Console.WriteLine(str1);
        }

        private static void OutDemo()
        {
            int result;
            float resultB;
            int resultC = 10;
            bool fnExecuted = add(out result, out resultB, resultC);
            Console.WriteLine(result);
            Console.WriteLine(resultB);
            Console.WriteLine(resultC);
        }

        static void SetValue(ref string str)
        {
            str = "Name Chnage inside fn";  //--NOT NECESSARILY be initialised and still works
        }
        
        public static bool add (out int a, out float  b, int c)
        {
            //Both reultA and resultB are passed as reference to the function by using 'out' and chnages made inside the fn are retianied
            //BUT NOT for resultC as its passed normally (not using 'out')
            //This can also be thought as returning multiple valueds from a fn and not just one (here; true)
            //Also ALL the out variables MUST ALWAYS be INitialised inside the Function irrespective whether they be initialsed prior 

            a = 20;
            a = a + a;
            b = 25;
            c = 1000;
            return true;
        }
    }
}
