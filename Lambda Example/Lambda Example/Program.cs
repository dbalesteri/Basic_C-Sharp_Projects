using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee0 = new Employee() { firstName = "Joe", lastName = "Cuppa", Id = 9 };
            Employee employee1 = new Employee() { firstName = "Joe", lastName = "King", Id = 4 };
            Employee employee2 = new Employee() { firstName = "Billy", lastName = "Jim", Id = 1 };
            Employee employee3 = new Employee() { firstName = "Bob", lastName = "Joe", Id = 3 };
            Employee employee4 = new Employee() { firstName = "Jim", lastName = "Cooper", Id = 15 };
            Employee employee5 = new Employee() { firstName = "Steve", lastName = "Miller", Id = 7 };
            Employee employee6 = new Employee() { firstName = "Hank", lastName = "Smith", Id = 2 };
            Employee employee7 = new Employee() { firstName = "Mike", lastName = "Williams", Id = 5 };
            Employee employee8 = new Employee() { firstName = "Dale", lastName = "Johnson", Id = 965 };
            Employee employee9 = new Employee() { firstName = "Harry", lastName = "Davis", Id = 6 };
            List<Employee> employees = new List<Employee>() { employee0, employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9 };

            List<Employee> joesForEach = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    joesForEach.Add(employee);
                    //Console.WriteLine(employee.firstName);
                }
            }

            List<Employee> joesLambda = employees.Where(x => x.firstName == "Joe").ToList();
            List<Employee> highIds = employees.Where(x => x.Id > 5).ToList();

            //foreach (Employee employee in highIds)
            //{
            //    Console.WriteLine(employee.Id);
            //}

            Console.ReadLine();
            
        }
    }
}
