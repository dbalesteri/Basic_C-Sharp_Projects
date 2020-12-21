using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { firstName = "Sandy", lastName = "Sanguine", Id = 3 };
            Employee employee2 = new Employee() { firstName = "Luigi", lastName = "Marinara", Id = 3 };
            if (employee1 == employee2)
            {
                Console.WriteLine("These employees have matching Ids.");
            }
            else
            {
                Console.WriteLine("The employees do not have matching Ids.");
            }
            Console.ReadLine();
        }
    }
}
