using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Enter Hourly Rate for Person 1: ");
            int firstRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hours Worked per Week for Person 1: ");
            int firstHours = Convert.ToInt32(Console.ReadLine());
            int firstSalary = firstRate * firstHours * 52;
            Console.WriteLine("Enter Hourly Rate for Person 2: ");
            int secondRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hours Worked per Week for Person 2: ");
            int secondHours = Convert.ToInt32(Console.ReadLine());
            int secondSalary = secondRate * secondHours * 52;
            Console.WriteLine("Annual salary of Person 1: " + firstSalary);
            Console.WriteLine("Annual salary of Person 2: " + secondSalary);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(firstSalary > secondSalary);
            Console.ReadLine();
        }
    }
}
