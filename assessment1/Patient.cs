using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace assessment1
{
    class PatientModule
    {
        public string Firsname;
        public string LastName;
        public string email;
        public string DOB;
        public byte age;
        public string gender;
        public string race;
        public string ethinicity;
        public string[] languages;
        public string address;
        ListDictionary emergencyContact = new ListDictionary();

    }
}
