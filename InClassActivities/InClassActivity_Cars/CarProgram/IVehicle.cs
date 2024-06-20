using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    internal interface IVehicle
    {
        //properties set for each car
        public int WheelNumber { get; }

        //methods for each car
        public void Stop();
        public void Start();

        public void Accelerate();

    }
}
