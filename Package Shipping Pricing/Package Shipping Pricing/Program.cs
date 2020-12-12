using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Shipping_Pricing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
 
            } else
            {
                Console.WriteLine("Please enter the package height:");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                decimal length = Convert.ToDecimal(Console.ReadLine());
                decimal cost = weight * height * length;
                if ( height * length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                } else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + Math.Round(cost, 2));
                    Console.WriteLine("Thank you!");
                }
            }
            
            Console.ReadLine();
        }
    }
}
