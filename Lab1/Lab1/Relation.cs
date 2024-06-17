using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Relation 
    {
        // Propertieswith values Sister, Brother, Mother or Father
        public string RelationType { get; set; }

        public Relation(string relationType)
        {
            RelationType = relationType;
        }

        /// <summary>
        /// Shows the realtionship between two people
        /// </summary>
        /// <param name="relationType"></param>
        public void ShowRelationShip(Person person1, Person person2, string relationType)
        {
            // Accepts two Person objects and displays the relationship between them
            switch(relationType)
            {
                case "Sister":
                    relationType = "Sisterhood";
                    break;
                case "Brother":
                    relationType = "Brotherhood";
                    break;
                case "Mother":
                    relationType = "Motherhood";
                    break;
                case "Father":
                    relationType = "Fatherhood";
                    break;
                default:
                    relationType = "Unknown";
                    break;
            }

            // Display the relationship between the two people
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {relationType}");
        }

    }
}
