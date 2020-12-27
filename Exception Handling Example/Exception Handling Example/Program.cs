using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! How old are you?");
            bool validAge = false;
            while (!validAge)
            {
                try
                {
                    int age = 0;
                    validAge = int.TryParse(Console.ReadLine(), out age);
                    if (!validAge) throw new FormatException();
                    if (age <= 0) throw new FradulantAgeException();
                    Console.WriteLine("Thank you for entering a valid answer, your age is: " + age);
                    Console.ReadLine();
                }
                catch (FormatException) //exception if someone enters anything other than a valid int
                {
                    Console.WriteLine("Please enter a whole number, no decimals.");
                }
                catch (FradulantAgeException) //custom exception for an age 0 or below
                {
                    Console.WriteLine("Your age is not 0 or below. Please enter a whole number, no decimals, greater than 0.");
                    validAge = false;
                }
                catch (Exception) //general exception
                {
                    Console.WriteLine("An error has occured. Please contact your system administrator");
                    Console.ReadLine();
                    return;
                }
            }
        }
    }
}
