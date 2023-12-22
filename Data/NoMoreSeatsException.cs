using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{

    public class NoMoreSeatsException : Exception
    {
        public NoMoreSeatsException() : base("Invalid: No more seat available")
        {

        }

        public NoMoreSeatsException(string numberOfSeats) : base("Invalid Number of seats available:" + numberOfSeats)
        {

        }
    }
}