using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram2
{
    internal class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public float Age { get; set; }
        public float Height { get; set; }

        public Cat(string name, float height, string colour, float age)
        {
            Name = name;
            Height = height;
            Colour = colour;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Cat eat mice");
        }

        public string Cry()
        {
            return "Meow!";
        }
    }
}
