using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Example
{
    public class FradulantAgeException : Exception
    {
        public FradulantAgeException()
            : base() { }
        public FradulantAgeException(string message)
            : base(message) { }
    }
}
