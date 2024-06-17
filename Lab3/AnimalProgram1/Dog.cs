using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram1
{
    internal class Dog : Animal
    {
        /// <summary>
        /// Method for displaying the eating habits of a dog
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("Dog eat meat.");
        }

        public Dog(string dogName, string dogColour, float dogAge)
        {
            Name = dogName;
            Colour = dogColour;
            Age = dogAge;
        }
    }
}
