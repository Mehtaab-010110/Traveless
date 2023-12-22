using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{

	public class InvalidCitizenshipException : Exception
	{
		public InvalidCitizenshipException() : base("Invalid: The citizenship is not valid")
		{

		}
        
		public InvalidCitizenshipException(string citizenship) : base("Invalid Citizinship: "+ citizenship)
        {

        }
    }
}
