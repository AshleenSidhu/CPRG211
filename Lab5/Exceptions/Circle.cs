using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Circle
    {
        private double radius { get; set; }

        // Default constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        //Method to check if the radius is greater than zero and sets the radius
        public void SetRadius(double radius)
        {
            if (radius <= 0)
            {
                // Throw an exception that displays the radius value
                throw new InvalidRadiusException(radius);
            }
            else
            {
                // Set the radius
                this.radius = radius;
                Console.WriteLine("Radius is Valid");
            }

        }

        public override string ToString()
        {
            return $"Circle Radius: {radius}\n";
        }
    }
}