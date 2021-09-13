using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_Polymorphism
{   
    class User
    {
        public string Name { get; }
        public User(string name)
        {
            Name = name;
        }

        static User()
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
            Employee e1 = new Employee("Ram");
            //e1.Enter(); //Pubic method of super class can simply be called
            e1.newEnter();
            
            //User u1 = new User("raj");
           // u1.Enter();
           // u1.newEnter();

           // User u2 = new Employee("Ravi");
           // u2.Enter(); //-calls the super class method --- !!!

            Employee e4 = new Employee("Ram");
            Console.WriteLine(e4.Name);
            Console.ReadLine();
        }
    }
}
