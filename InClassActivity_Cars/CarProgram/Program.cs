namespace CarProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Car Program!\n");

            var car1 = new Car("Toyota", "Corolla", 1.8f, "Red", 4);

            car1.Start();
            car1.Stop();
            car1.Accelerate();
            
            
        }
    }
}
