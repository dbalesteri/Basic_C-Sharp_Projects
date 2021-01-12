using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Constructors_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hi {0}, how old are you?", name);
            int age = Convert.ToInt32(Console.ReadLine());
            var person = new Person(name, age); //utilize var keyword instead of explicitly giving variable person type of Person class
            if (person.IsOverTwentyOne)
            {
                Console.WriteLine("{0}, you are old enough to purchase alcohol in the U.S.", name);
            }
            else
            {
                Console.WriteLine("{0}, you are not old enough to purchase alcohol in the U.S.", name);
            }
            Console.ReadLine();
        }
    }
}
