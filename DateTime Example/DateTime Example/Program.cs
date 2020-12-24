using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // print current datetime to the console
            Console.WriteLine("Please enter in a whole number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1 || num == -1) // if statement to check for 1 for singular hour vs multiple hours
            {
                Console.WriteLine("It will be: {0} in {1} hour.", DateTime.Now.AddHours(num), num); //add user entered hour to current time
            }
            else
            {
                Console.WriteLine("It will be: {0} in {1} hours.", DateTime.Now.AddHours(num), num); //add user entered hours to current time
            }
            Console.ReadLine();
        }
    }
}
