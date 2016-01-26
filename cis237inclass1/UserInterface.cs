using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {
        // Private variables - No need for local variables, so there are no private
        // variable declarations for this class.

        // Properties - Since there are no local variables, there is no need for
        // public properties, so I don't need that section either.

        // Public methods - we will have some of these!

        // This will print the menu to the screen, and await a valid input
        // from the user. Once the input is valid, it will return the 
        // number that they selected.
        public int GetUserInput()
        {
            // Let's print the menu first.
            this.PrintMenu();

            // Get user input from the terminal. Whatever they type will come
            // back as a string once they push enter on the keyboard. 
            String input = Console.ReadLine();

            // while the input is NOT valid
            while(input != "1" && input != "2")
            {
                // Tell them that they did not enter a valid choice
                Console.WriteLine("That is not a valid entry.");
                Console.WriteLine("Please make a valid choice.");
                Console.WriteLine();
                // Reprint the menu for the user.
                this.PrintMenu();
                // Refetch the user input from the console.
                input = Console.ReadLine();
            }

            // I know since we are out of the while loop that it must be either
            // a 1 or a 2, so there is no need for me to use a try / catch here.
            // I could, but it should NEVER hit the catch.
            return Int32.Parse(input);
        }

        // Take in a string that we would like output to the screen.
        // I realize that this will be about the same as just using a 
        // Console.WriteLine, but by defining this here, we could
        // replace this class with a web one that might be more involved
        // without ever having to touch the other classes of the program.
        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        // This is just a private method to print the Menu. It will probably
        // happen quite a bit, so it makes sense that it is in a method.
        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }


        // Constructors - No need fo any constructors either. We will
        // just use the automatic default one that is provided to us. 
        // We can't see it, but trust me, it's available. 
    }
}
