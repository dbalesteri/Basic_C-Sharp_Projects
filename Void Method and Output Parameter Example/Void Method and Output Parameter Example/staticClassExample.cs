using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_and_Output_Parameter_Example
{
    static class staticClassExample
    {
        public static void nameChanger(out string firstName, out string lastName) //method with output parameters
        {
            Random random = new Random();
            List<string> firstNames = new List<string> { "Doug", "Peter", "Frank N.", "Danny", "Yukon" };
            List<string> lastNames = new List<string> { "Dimmadome", "Parker", "Furter", "Zuko", "Cornelious" };
            firstName = firstNames[random.Next(0, 5)];
            lastName = lastNames[random.Next(0, 5)];
        }
    }
}
