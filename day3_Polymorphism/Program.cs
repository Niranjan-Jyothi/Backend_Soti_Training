using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_Polymorphism
{   
    enum role  //Use always when u have fixed options for a variable to be used later
    {
        Developer, Delevery_Manager
    }
    class User
    {
        public string Name { get; }
        public const int age  = 10; //Can't be accessed by "this. "  AND by default it is static
        public role role { get; set; }

        public User(string name)
        {   
            
            this.Name = name;
            Console.WriteLine($"Age = {User.age}"); //Calling static variables using the Class refernce ONLY and NOT this.
        }

        static User()  //Called only once and it CANNOT take any arguments
        {
            Console.WriteLine("Static Called");
        }

        public void Enter()
        {
            Console.WriteLine("Entered");
            
        }

        public virtual void newEnter()
        {
            Console.WriteLine("In USer New-Entered FN");
        }
    }

    class Employee : User
    {   
        public Employee(string name): base(name)
        {
            //No code as we are using the same code from super-class
        }
        public void newEnter()  // Virtual -> Override the parent
        {
            Console.WriteLine("Inside New Enter Function of Employee(sub-class)- Overriding the parent class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            //basics();
            enumeration();

            Console.WriteLine("Press a Key to Exit ..");
            Console.ReadLine();
        }

        private static void basics()
        {
            Employee e1 = new Employee("Ram");
            e1.Enter(); //Pubic method of super class can simply be called
            e1.newEnter();

            User u1 = new User("raj");
            u1.Enter();
            u1.newEnter();

            User u2 = new Employee("Ravi");
            u2.Enter(); //-calls the super class method --- !!!

            Employee e4 = new Employee("Ram");
            Console.WriteLine(e4.Name);
        }

        private static void enumeration()
        {
            Employee e1 = new Employee("Rao");
            e1.role = role.Delevery_Manager;
            Console.WriteLine(e1.role); //get the role name
            Console.WriteLine((int)e1.role);  // get the index of that role inside the role enum
            string emp_role = e1.role.ToString();
        }
    }
}
