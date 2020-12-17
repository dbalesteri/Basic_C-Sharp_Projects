using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplication multiplication = new Multiplication();
            Console.WriteLine("Hello! Here's a simple program with an optional input.\nWhat whole number would you like to multiply by two?:");
            bool validAnswer1 = false;
            bool validAnswer2 = false;
            bool validAnswer3 = false;
            while (!validAnswer1)
            {
                try
                {
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Before we calculate, as an option, would you like to add another number to the equation to multipy it by further?");
                    Console.WriteLine("Note it's not necessary.");
                    while (!validAnswer2)
                    {
                        try
                        {
                            Console.WriteLine("Enter \"yes\" or \"no\" if you'd like to add another factor:");
                            string answer = Console.ReadLine();
                            if (answer == "yes")
                            {
                                validAnswer2 = true;
                                while (!validAnswer3)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter second number:");
                                        int input2 = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("The result is: " + input1 + " * 2 * " + input2 + " = " + multiplication.Multiply(input1, input2));
                                        validAnswer3 = true;
                                    }
                                    catch (FormatException ex)
                                    {
                                        Console.WriteLine("Invalid input. Enter a whole number:");
                                    }
                                    catch (OverflowException ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        Console.WriteLine("Answer cannot exceed 2,147,483,648. Enter a smaller number.");
                                    }
                                }
                            }
                            else if (answer == "no")
                            {
                                Console.WriteLine("The result is: " + input1 + " * 2 = " + multiplication.Multiply(input1));
                                validAnswer2 = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. \"yes\" or \"no\" was not entered.");
                            }
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Answer cannot exceed 2,147,483,648. Enter a smaller number:");
                        }
                        
                    }
                    validAnswer1 = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Enter a whole number:");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Enter a number 1073741824 or less:");
                }
            }
            Console.WriteLine("That's it, press enter to exit!");
            Console.ReadLine();
        }
    }
}
