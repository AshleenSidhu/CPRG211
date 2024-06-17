namespace AnimalProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of your dog: ");
            var dogName = Console.ReadLine();

            // Ask user for properties of the dog
            Console.Write("Enter the colour of the dog: ");
            //dog.Colour = Console.ReadLine();
            var dogColour = Console.ReadLine();

            Console.Write("Enter the age of the dog: ");
            //dog.Age = Convert.ToInt32(Console.ReadLine());
            float dogAge = Convert.ToInt32(Console.ReadLine());

            // Create a new dog object
            Dog dog = new Dog(dogName, dogColour, dogAge);
            
            // Display the properties of the dog
            Console.WriteLine("\nYour Dog:");
            Console.WriteLine($"Dog's name is {dog.Name}");
            Console.WriteLine($"Dog's colour is {dog.Colour}");
            Console.WriteLine($"Dog's age is {dog.Age}");

            // Call the Eat method
            Console.WriteLine("\nDog's eating habits:");
            dog.Eat();

            // Ask user for properties of the cat
            Console.Write("\nEnter the name of your cat: ");
            string catName = Console.ReadLine();

            Console.Write("Enter the colour of the cat: ");
            string catColour = Console.ReadLine();

            Console.Write("Enter the age of the cat: ");
            float catAge = Convert.ToInt32(Console.ReadLine());

            // Create a new cat object
            Cat cat = new Cat(catName, catColour, catAge);

            // Display the properties of the cat
            Console.WriteLine("\nYour Cat:");
            Console.WriteLine($"Cat's name is {cat.Name}");
            Console.WriteLine($"Cat's colour is {cat.Colour}");
            Console.WriteLine($"Cat's age is {cat.Age}");

            Console.WriteLine("\nCat's eating habits:");
            // Call the Eat method
            cat.Eat();




        }
    }
}
