using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram
{
    internal class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat eat mice.");
        }

        public Cat(string catName, string catColour, float catAge)
        {
            Name = catName;
            Colour = catColour;
            Age = catAge;
        }
    }
}
