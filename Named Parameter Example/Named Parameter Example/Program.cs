using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            exampleClass exampleClass = new exampleClass();
            bool validAnswer = false;

            while (!validAnswer)
            {
                try
                {
                    Console.WriteLine("Enter in a whole number:");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    bool validAnswer2 = false;
                    while (!validAnswer2)
                    {
                        try
                        {
                            Console.WriteLine("Enter in another whole number:");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("The output is:");
                            exampleClass.voidMethod(num1: input1, num2: input2);
                            validAnswer2 = true;
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
                    validAnswer = true;
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
