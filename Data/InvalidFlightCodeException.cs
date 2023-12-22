using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{

    public class InvalidFlightCodeException : Exception
    {
        public InvalidFlightCodeException() : base("Invalid: The flight code is not valid")
        {

        }

        public InvalidFlightCodeException(string flightCode) : base("Invalid Flight Code:" + flightCode) 
        {
            
        }
    }
}
