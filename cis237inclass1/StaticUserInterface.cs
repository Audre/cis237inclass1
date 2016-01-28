using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class StaticUserInterface
    {
        // We made the method static and it is inside a static class
        // This means that this method can be called using the class name
        // instead of an instance. We can see how to call this metho over
        // in the program class. It still does all the same work as the
        // instanced version, only it cannot use the 'this' keyword because
        // this refers to an instance, and since this is static, there is
        // no instance. Only this one. 
        public static int GetUserInput()
        {
            
            PrintMenu();

            
            String input = Console.ReadLine();

            // while the input is NOT valid
            while (input != "1" && input != "2")
            {
                // Tell them that they did not enter a valid choice
                Console.WriteLine("That is not a valid entry.");
                Console.WriteLine("Please make a valid choice.");
                Console.WriteLine();
                // Reprint the menu for the user.
                PrintMenu();
                // Refetch the user input from the console.
                input = Console.ReadLine();
            }

            // I know since we are out of the while loop that it must be either
            // a 1 or a 2, so there is no need for me to use a try / catch here.
            // I could, but it should NEVER hit the catch.
            return Int32.Parse(input);
        }

        
        public static void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        
        private static void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }
    }
}
