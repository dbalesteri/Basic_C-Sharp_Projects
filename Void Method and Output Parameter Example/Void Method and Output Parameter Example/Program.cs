using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_and_Output_Parameter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass exampleClass = new ExampleClass();
            Console.WriteLine("Hello, we'll be dividing by 2 today.");
            bool validAnswer = false;

            while (!validAnswer)
            {
                try
                {
                    Console.WriteLine("Enter a whole number:");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your answer is:");
                    exampleClass.voidMethod(input1);
                    validAnswer = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input.");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    Console.WriteLine("This time, we'll divide two numbers by 2 and display at once.");
                    Console.WriteLine("Enter a whole number for the first answer:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Now, enter a whole number for the second answer:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your results:");
                    exampleClass.voidMethod(num1, num2);
                    validAnswer = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input.");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Next, what's your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ok, what's your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("That's a fine name, " + firstName + " " + lastName + ".");
            Console.WriteLine("Here's a better one though.");
            bool anotherName = false;
            while (!anotherName)
            {
                staticClassExample.nameChanger(out firstName, out lastName);
                Console.WriteLine("I now pronounce you:\n\n\"" + firstName + " " + lastName + "\"\n\nNo need to thank me.");
                Console.WriteLine("Would you like another? Type \"yes\" or \"no\".");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    anotherName = false;
                }
                else if (answer == "no")
                {
                    anotherName = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. \"yes\" or \"no\" was not entered.");
                }
            }

            Console.WriteLine("That's all there is, press enter to exit!");
            Console.ReadLine();
        }
    }
}
