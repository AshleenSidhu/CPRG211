using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram2
{
    internal class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public float Age { get; set; }
        public float Height { get; set; }

        public Dog(string name, float height, string colour, float age)
        {
            Name = name;
            Height = height;
            Colour = colour;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Dog eat meat");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
}
