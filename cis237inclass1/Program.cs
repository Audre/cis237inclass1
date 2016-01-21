using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a couple instances of the Employee class
            Employee employee1 = new Employee("Dave", "Barnes", 537.00m);
            Employee employee2 = new Employee("Joe", "Somebody", 125.50m);

            // create a simple int that will be used for value vs reference
            int myNumber = 5;

            // write the value of the int before the method, call the method, print after call.
            Console.WriteLine(myNumber);
            ChangeAnInt(myNumber);
            Console.WriteLine(myNumber);

            // write the value of the employee before the method, call the method, print after call.
            Console.WriteLine(employee1.ToString());
            ChangeAnObject(employee1);
            Console.WriteLine(employee1.ToString());

            //Console.WriteLine(employee.GetFullName());
            //Console.WriteLine(employee.ToString());

            // showing how to use an array with objects
            Employee[] employees = new Employee[10];

            // instanciate some employees into the array
            employees[0] = new Employee("James", "Kirk", 453.00m);
            employees[1] = new Employee("Jean-Luc", "Picard", 290.00m);
            employees[2] = new Employee("Benjamin", "Sisko", 587.00m);
            employees[3] = new Employee("Kathryn", "Janeway", 194.00m);
            employees[4] = new Employee("Johnathan", "Archer", 394.00m);

            //a for each loop that will loop through each element of the employees array
            foreach (Employee employee in employees)
            {
                // check to make sure that the current object is null.
                // we know that the first 5 have values because we assigned them right above
                // but the last 5 are null, so we better put in a check.
                if (employee != null)
                {
                    // output the information of the employees.
                    Console.WriteLine(employee.ToString());
                }
            }
        }

        //this method takes in an integer, which is passed by value
        // and then changes the value of it.
        static void ChangeAnInt(int myNumber)
        {
            myNumber = 456;
        }

        //this method takes in an Employee class, which is passed by reference
        // and then changes a property of it.
        static void ChangeAnObject(Employee employee)
        {
            employee.FirstName = "Thor";
        }
    }
}
