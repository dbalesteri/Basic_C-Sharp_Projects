using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload_Examples
{
    class Addition
    {
        public int Add(int input)
        {
            return checked(input + 10);
        }

        public int Add(decimal input)
        {
            return Convert.ToInt32(checked(input + 20m));
        }

        public int Add(string input)
        {
            return checked(Convert.ToInt32(input) + 30);
        }

    }
}
