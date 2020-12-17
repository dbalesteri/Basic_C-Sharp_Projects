using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameter_Example
{
    class Multiplication
    {
        public int Multiply(int num1, int num2 = 1)
        {
            return checked(num1 * num2 * 2);
        }

    }
}
