using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee() { firstName = "John", lastName = "Doe" };
            employee.Quit();
            Console.ReadLine();
        }
    }
}
