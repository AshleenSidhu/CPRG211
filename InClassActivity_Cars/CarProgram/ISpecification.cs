using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    internal interface ISpecification
    {
        //properties set for each car
        public string Model { get; }
        public string Make { get; }
        public float EngineSize { get;  }

        public double HorsePower();
    }
}
