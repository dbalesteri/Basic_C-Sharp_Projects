using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! here are some examples of methods.");
            Addition addition = new Addition();
            Console.WriteLine("Enter a whole number to add 10 to:");
            bool validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The result is: " + addition.Add(firstNumber));
                    validAnswer = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Enter a whole number:");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Due to system integer limitations, invalid input. Enter a whole number between -2,147,483,648 and 2,147,483,637.");
                }
            }
            Console.WriteLine("Enter a number to add 20 to (answers with decimal inputs will be rounded):");
            Addition additionSecond = new Addition();
            validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("The result is: " + additionSecond.Add(secondNumber));
                    validAnswer = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Enter a whole number:");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Enter a number to add 30 to:");
            Addition additionThird = new Addition();
            validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    string thirdNumber = Console.ReadLine();
                    Console.WriteLine("The result is: " + additionThird.Add(thirdNumber));
                    validAnswer = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Enter a number:");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("That's it, press enter to exit!");
            Console.ReadLine();
        }
    }
}
