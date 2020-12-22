using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week:");
            bool validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    userInput = char.ToUpper(userInput[0]) + userInput.Substring(1);
                    bool validOption = Enum.IsDefined(typeof(DayOfWeek), userInput);
                    if (!validOption)
                    {
                        Console.WriteLine("Please enter an acutal day of the week:");
                        continue;
                    }
                    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput);
                    Console.WriteLine("You entered: " + day);
                    validAnswer = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an acutal day of the week:");
                }
            }
            Console.WriteLine("That's all, thank you.");
            Console.ReadLine();
        }
    }
}
