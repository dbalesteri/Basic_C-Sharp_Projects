using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_and_Output_Parameter_Example
{
    class ExampleClass
    {
        public void voidMethod (int num)
        {
            Console.WriteLine(num / 2);
        }

        public void voidMethod (int num1, int num2)
        {
            Console.WriteLine("Answer 1: " + num1 / 2 + "\nAnswer 2: " + num2 / 2);
        }

        
    }
}
