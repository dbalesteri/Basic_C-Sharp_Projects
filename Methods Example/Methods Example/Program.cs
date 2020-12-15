using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Exponential powers = new Exponential();
            Console.WriteLine("Hello! Let's do some math.");
            Console.WriteLine("Give me a whole number to raise to the 2nd power:");
            bool validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    int numberOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The answer is: " + powers.Square(numberOne));
                    validAnswer = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Enter a whole number:");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Due to system integer limitations, invalid input. Enter a whole number between -46340 and 46340");
                }
            }
            Console.WriteLine("Cool! Now give me a whole number to raise to the 3rd power:");
            validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    int numberTwo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The answer is: " + powers.Cube(numberTwo));
                    validAnswer = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Enter a whole number:");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Due to system integer limitations, invalid input. Enter a whole number between -1290 and 1290");
                }
            }
            Console.WriteLine("Sweet! Now give me a whole number to raise to the 4th power:");
            validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    int numberThree = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The answer is: " + powers.Quartic(numberThree));
                    validAnswer = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Enter a whole number:");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Due to system integer limitations, invalid input. Enter a whole number between -215 and 215");
                }
            }
            Console.WriteLine("Thanks! Press enter to exit.");
            Console.ReadLine();
        }
    }
}
