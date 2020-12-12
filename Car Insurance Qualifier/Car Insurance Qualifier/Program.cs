using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Qualifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Qualifier Program");
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\":");
            bool DUI = Convert.ToBoolean(Console.ReadLine().ToLower());
            Console.WriteLine("How many speeding tickets do you have? Please answer with a digit.");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool qualified = age > 15 && DUI == true && tickets <= 3;
            Console.WriteLine("Qualified?: " + qualified);
            Console.ReadLine();


        }
    }
}
