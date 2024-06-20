using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProgram
{
    public class Car : IVehicle, IColour, ISpecification
    {
        public int WheelNumber { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public float EngineSize { get; set; }
        public string Colour { get; set; }

        public double HorsePower() { return EngineSize * 110; }

        public void Stop()
        {
            Console.WriteLine($"The Car Engine stopped for {Make} model {Model}, {Colour} colour " +
                $"which has {WheelNumber} amount of wheels and {EngineSize} liter. " +
                $"amount of wheels with horse power of {HorsePower()}");
        }

        public void Start()
        {
            Console.WriteLine($"The Car Engine started for {Make} model {Model}, {Colour} colour " +
                $"which has {WheelNumber} amount of wheels and {EngineSize} liter. " +
                $"amount of wheels with horse power of {HorsePower()}");
        }

        public void Accelerate()
        {
            Console.WriteLine($"{Make} {Model} with {WheelNumber} amount of wheels is running.");
            
        }

        public Car(string make, string model, float engineSize, string colour, int wheelNumber)
        {
            Make = make;
            Model = model;
            EngineSize = engineSize;
            Colour = colour;
            WheelNumber = wheelNumber;
        }
    }
    
}
