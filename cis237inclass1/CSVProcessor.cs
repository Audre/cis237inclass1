﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CSVProcessor
    {
        public bool ImportCSV(string pathToCSVFile, Employee[] employees)
        {
            StreamReader streamReader = null;

            try
            {
                // declare a string to represent a line we read
                string line;

                // Create a new instance of the StreamReader class
                streamReader = new StreamReader(pathToCSVFile);

                // Create a counter to know what index to place the new object
                int counter = 0;

                // This line is doing a bunch of stuff. i tis reading a line from
                // the file. It is assigning that info to the 'line' variable, and
                // lastly it is makin gsur ethat what it just read was not null.
                // If it is null, we are done reading the file and we can exit the
                // loop. 
                while ((line = streamReader.ReadLine()) != null)
                {
                    processLine(line, employees, counter++);
                }

                return true;
            }

            catch (Exception ex)
            {
                // Spit out the errros that occured. 
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            finally
            {
                // If an instance of the streamReader was made, we want to ensure 
                // that we close it. The finally block is a perfect spot to put it 
                // since it will get called regardless of whether or not the try
                // succeeded.
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        private void processLine(string line, Employee[] employees, int index)
        {
            // Split the line into parts and assign the parts to a string array
            string[] parts = line.Split(',');

            // Create some local variable and assign the various parts to them. 
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            // Now we just need to add a new employee to the array and use the parts
            // we parsed out. If you had a collection class, I would hope that it has
            // a method that you made called 'add' that would then do the work of
            // adding a new employee to the collection. 
            employees[index] = new Employee(firstName, lastName, salary);
        }
    }
}
