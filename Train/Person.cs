using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    internal class Person {
        string firstName;
        string lastName;

        public string FirstName{ get; set; }
        public string LastName{ get; set; }

        public Person(string firstName, string lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
