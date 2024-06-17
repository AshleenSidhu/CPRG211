namespace AnimalProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of your dog: ");
            var dogName = Console.ReadLine();

            // Ask user for properties of the dog
            Console.Write("Enter the colour of the dog: ");
            var dogColour = Console.ReadLine();

            Console.Write("Enter the age of the dog: ");
            float dogAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the height of the dog: ");
            float dogHeight = float.Parse(Console.ReadLine());

            // Create a new dog object
            Dog dog = new Dog(dogName, dogHeight, dogColour, dogAge);

            dog.Eat();
            dog.Cry();

            // Ask user for properties of the cat
            Console.Write("\nEnter the name of your cat: ");
            string catName = Console.ReadLine();

            Console.Write("Enter the colour of the cat: ");
            string catColour = Console.ReadLine();

            Console.Write("Enter the age of the cat: ");
            float catAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the height of the dog: ");
            float catHeight = float.Parse(Console.ReadLine());

            // Create a new cat object
            Cat cat = new Cat(catName, catHeight, catColour, catAge);

            cat.Eat();
            cat.Cry();

            // Creat another dog object
            Dog dog2 = new Dog("Champ", 1.5f, "Brown", 6);

            // Create a list for animals and add the animals to the list
            List<IAnimal> animals = new List<IAnimal> { dog, cat, dog2 };

            foreach (var animal in animals)
            {
                Console.WriteLine($"\nName: {animal.Name}");
                Console.WriteLine($"Colour: {animal.Colour}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"Height: {animal.Height}");
            }

        }
    }
}
