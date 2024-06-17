using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProgram2
{
    internal interface IAnimal
    {
        //properties of the animal
        public string Name { get; set; }
        public string Colour { get; set; }
        public float Age { get; set; }
        public float Height { get; set; }

        // Methods of animal
        public void Eat();

        public string Cry();

    }
}
