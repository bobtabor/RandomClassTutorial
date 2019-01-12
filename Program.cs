using System;

namespace RandomClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Random class creates a Random number.


            // First create an instance of the class:
            // Random random = new Random();

            // Then use that instance's Next() method:
            /*
            int randomNumber = random.Next();
            Console.WriteLine(randomNumber);
            */

            // Or, pass in lower and upper boundaries:
            /*
            int randomNumber = random.Next(100, 201);
            Console.WriteLine(randomNumber);
            */

            // Note: upper boundary is "exclusive", meaning
            // it will never use that number (only less than).


            // What's more interesting than what this
            // specific class DOES is how we create a 
            // new instance of the class BEFORE we use 
            // it.

            // The new keyword is important: it creates a new 
            // instance of a class.

            // Why can't I do this?
            // Console console = new Console();

            // There's a difference between INSTANCE CLASSES
            // and STATIC CLASSES.

            // STATIC CLASSES use the static keyword, and do not 
            // maintain state.  They contain pure methods that 
            // leave no side effects / state change after you 
            // run those methods (at least, not internally).

            // INSTANCE CLASSES do NOT use the static keyword.
            // These classes do maintain state, and the methods 
            // in these classes are likely to leave side effects
            // / change state.

            // The methods of the Console class are stateless.
            // They do their job, and they exit.

            // The methods of Random class maintain a value internally
            // to help generate a random number (thus the term 'Next').

            // How will you know the difference?
            // Experience, Intellisense, Compilation errors

            // Where is this "state" maintained in INSTANCE CLASSES?
            // Fields and properties ... we'll talk about that 
            // later.

            // When you create an instance of a class, you refer to 
            // that instance as an "Object".  Objects are "mortal".
            // They have lifetimes: they are born, they live and they die.  
            // This is important for reasons you'll learn later.

            // Static classes are "eternal" in a sense.  They're always
            // alive and never die.


        }
    }
}
