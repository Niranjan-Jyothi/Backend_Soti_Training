using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("1. Register \n2. Forgot/Change Password \n3. Login");
                Console.WriteLine("Choose your option (1/2)");
                int op = Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        register_new_user();
                        enterPatientBasicDetails();
                        break;

                    case 2:
                        break;

                    case 3:
                        Console.WriteLine("Login Screen");
                        break;

                }

            }
            

        }

        private static void enterPatientBasicDetails()
        {
            
        }

        private static void register_new_user()
        {

            Patient p1 = new Patient("Meeting1", "Ram", "abgmail", "10/11/2020", 98022929, "pass123");
            Console.WriteLine("USer data entered and registered");
            
        }
    }
}
