using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 0, 1, 4, 9, 16, 25, 36, 49, 64, 81 };

            Console.WriteLine("I have a list of integers:");
            foreach (int integer in integers)
            {
                Console.Write(integer + " ");
            }

            Console.WriteLine("\nWhat number would you like to divide each one by?");
            
            try
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Calculating...");
                foreach (int integer in integers)
                {
                    int answer = integer / userNumber;
                    Console.Write(answer + " ");
                }
                Console.WriteLine("");
            } 
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPlease enter a whole number. One was not entered.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nDo not divide by zero. Dividing by zero is undefined.");
            }
            Console.WriteLine("\nThe program has emerged from a try/catchblock and continued on with execution.");
            Console.ReadLine();
        }
    }
}
