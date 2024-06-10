namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Person objects 
            Person ian = new(1, "Ian" , "Brooks", "Red", 30, true);
            Person gina = new(2, "Gina", "James", "Green", 18, false);
            Person mike = new(3, "Mike", "Briscoe", "Blue", 45, true);
            Person mary = new(4, "Mary", "Beals", "Yellow", 28, true);

            // Dsiplay Ginas personID. full name, and favorite color
            gina.DisplayPersonInfo();

            // Display all of Mike's information
            Console.WriteLine(mike.ToString());

            // Change Ian's favorite color then display all of Ian's information as a sentence
            ian.ChangeFavoriteColor();
            ian.DisplayPersonInfo();

            // Create Relation objects
            Relation relation = new("Sister");
            Relation relation2 = new("Brother");

            // Display relationships
            relation.ShowRelationShip(gina, mary, "Sister");
            relation.ShowRelationShip(ian, mike, "Brother");

            // Add all Person Objects to a list
            List<Person> peopleList = new List<Person> { ian, gina, mike, mary };


            int Agesum = 0;

            foreach (Person person in peopleList)
            {
                Agesum += person.Age;
            }

            // Calculate Average of ages in the list
            float totalAverage = (float)Agesum / peopleList.Count;



        }
    }
}
