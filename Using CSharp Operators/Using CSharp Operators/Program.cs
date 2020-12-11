using System;

namespace Using_CSharp_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");
            Console.WriteLine("Pick a number to multiply by 50: ");
            double product = Convert.ToDouble(Console.ReadLine()) * 50;
            Console.WriteLine("And like magic, the product is: " + product);
            Console.WriteLine("");
            Console.WriteLine("Now, pick a number to add to 25: ");
            int sum = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine("And again like magic, the sum is: " + sum);
            Console.WriteLine("");
            Console.WriteLine("Now, pick a number to be divided by 12.5: ");
            double quotient = Convert.ToDouble(Console.ReadLine()) / 12.5;
            Console.WriteLine("And with magic in likeness, the quotient is: " + quotient);
            Console.WriteLine("");
            Console.WriteLine("Now, pick a number to be compared if it's greater than 50: ");
            bool comparison = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine("And magical similarity rears it's head again, the answer is: " + comparison);
            Console.WriteLine("");
            Console.WriteLine("Finally, pick a number to be divided by 7 and returned it's remainder: ");
            int remainder = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine("And with magic on the mind one last time, the remainder is: " + remainder);
            Console.ReadLine();

        }
    }
}
