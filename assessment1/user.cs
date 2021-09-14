using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment1
{
    enum Role{
        Physician, Nurse, Admin
    }
    class User
    {
        string Title;
        string FirstName { get; set; }
        string Email { get; set; }
        string DOB { get; set; }

        public User(string title, string name, string email, string dob)
        {
            this.FirstName = name;
            this.Title = title;
            this.Email = email;
            this.DOB = dob;
            //Console.WriteLine("Baisc User details have been Entered and registered");
        }
        public void changePassword()
        {

        }
        public void FetchNotes()
        {

        }
    }  

    class Patient: User
    {
        public double ContactNumber { get; set; }
        private string password { get;  set; }

        public Patient(string title, string name, string email, string dob, double phone, string pass): base(title, name, email, dob)
        {
            this.ContactNumber = phone;
            this.password = pass;
        }
    }

    class Employee
    {
        public Role Role { get; set; }
        public string empId { get; set; }
    }
}
