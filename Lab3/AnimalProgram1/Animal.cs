using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram1
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public float Age { get; set; }
        public abstract void Eat();

    }
}
