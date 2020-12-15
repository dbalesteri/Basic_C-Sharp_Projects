using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Example
{
    class Exponential
    {
        public int Square(int input)
        {
            return checked(input * input);
        }

        public int Cube(int input)
        {
            return checked(input * input * input);
        }

        public int Quartic(int input)
        {
            return checked(input * input * input * input);
        }
    }
}
