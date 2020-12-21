using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Type_Parameter_Example
{
    public class Employee<T> : Person, IQuittable
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

        public List<T> Things { get; set; }
    }
}
