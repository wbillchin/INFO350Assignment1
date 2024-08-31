/*
 * INFO 350 - Spring 2024
 * 
 * Assignment 1
 * 
 */

/* Note how this is a comment - that does not affect the code at all.
   Everything between the forward slash - asterisk and then the
   asterisk - slash is ignored by the compiler when generating code
 */

/*
 * Some people like to format their comments this way.
 * 
 * Comments are important documentation in code to allow humans
 * to understand the code and you are expected to put reasonable
 * comments in the code you submit
 */

// This is also a comment - the double forward slashes indicate that
// the rest of the line is a comment

// Includes go here to bring in symbols that the code below would reference
using System;

// We will eventually discuss the set up here, but for now, pay attention
// to the code within the Main function below
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a typical first program that prints out to console
            // the sentence, "Hello World!"
            Console.WriteLine("Hello World!");

            // We can declare a variable like this:
            int birthYear = 2000;
            int thisYear = 2020;

            // And write it out to console like this:
            Console.WriteLine("The birth year is " + birthYear + ".");

            // Here is another way to print out a variable:
            Console.WriteLine("The current year is {0}.", thisYear);

            // You can combine them this way:
            Console.WriteLine("The given birth year is {0} and this year is {1}",
                birthYear, thisYear);


        }
    }
}