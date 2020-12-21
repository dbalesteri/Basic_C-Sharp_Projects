using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type_Parameter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>() { firstName = "Sandy", Id = 123, lastName = "Sanguine" };
            employee1.Things = new List<string>() { "badge", "uniform", "lunchbox" };
            Employee<int> employee2 = new Employee<int>() { firstName = "Luigi", Id = 321, lastName = "Marinara" };
            employee2.Things = new List<int>() { 98, 34, 17 };
            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
