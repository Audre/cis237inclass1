using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        // backing fields
        private string firstName;
        private string lastName;
        private decimal weeklySalary;

        // properties for the backing fields
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        // one method that is public. can be accessed from other classes
        public string GetFullName()
        {
            return this.firstName + " " + this.lastName;
        }

        // override method that will print all of the fields
        // it overrides the default ToString that every object gets for free!
        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.weeklySalary.ToString("C");
        }

        // one method that is private. can only be called from inside this class
        private string foo()
        {
            return "FOO";
        }

        // 3 parameter constructor
        public Employee(string firstName, string lastName, decimal weeklySalary)
        {
            // assign the passed in values to the fields
            this.firstName = firstName;
            this.lastName = lastName;

            // assign the passed in value by the property
            this.WeeklySalary = weeklySalary;
            //this.weeklySalary = weeklySalary;
        }

        // default constructor
        public Employee()
        {
            // let's just leave this blank
        }
    }
}
