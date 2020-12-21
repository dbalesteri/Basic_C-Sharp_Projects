using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator_Example
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("Hey boss,\nI quit.\nSincerely,\n" + firstName + " " + lastName);
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool duplicate;
            if (employee1.Id == employee2.Id)
            {
                duplicate = true;
            }
            else
            {
                duplicate = false;
            }
            return duplicate;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool duplicate;
            if (employee1.Id != employee2.Id)
            {
                duplicate = false;
            }
            else
            {
                duplicate = true;
            }
            return duplicate;
        }
    }
}
