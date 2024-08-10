using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidRadiusException : Exception
    {
        // No argument constructor that prints a message when radius is greater than zero
        public InvalidRadiusException() : base("Radius must be greater than zero.")
        {
        }

        // Constructor that accepts the radius value
        public InvalidRadiusException(double radius)
            : base($"Invalid radius: {radius}. Radius must be greater than zero.")
        {
        }

    }
}
