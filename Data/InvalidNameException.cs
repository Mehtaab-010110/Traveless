using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{

    public class InvalidNameException : Exception
    {
        public InvalidNameException() : base("Invalid: The name is not valid")
        {

        }

        public InvalidNameException(string name) : base("Invalid Name:" + name)
        {

        }
    }
}