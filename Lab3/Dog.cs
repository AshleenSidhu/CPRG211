using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram
{
    internal class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog eat meat.");
        }

        public Dog(string? dogName, string? dogColour, float dogAge)
        {
            Name = dogName;
            Colour = dogColour;
            Age = dogAge;
        }
    }
}
