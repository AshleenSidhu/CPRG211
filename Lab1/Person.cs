using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        private int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string FavoriteColor { get; set; }
        public int Age { get; set; }
        private bool IsWorking { get; set; }

        /// <summary>
        /// Creates a new person with it's values and information
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="favoriteColor"></param>
        /// <param name="age"></param>
        /// <param name="isWorking"></param>
        public Person(int personID, string firstName, string lastName, string favoriteColor, int age, bool isWorking = false)
        {
            // Assign the values to the properties
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            FullName = firstName + " " + lastName;
            FavoriteColor = favoriteColor;
            Age = age;
            IsWorking = isWorking;
        }

        /// <summary>
        /// Displays the persons information
        /// </summary>
        /// <param name="personID"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="favoriteColor"></param>
        /// <param name="age"></param>
        /// <param name="isWorking"></param>
        public void DisplayPersonInfo()
        {
            // Display the person's information
            Console.WriteLine($"{PersonID}: {FullName}'s favorite color is: {FavoriteColor}");
           
        }

        /// <summary>
        /// Changes the persons favorite color to White
        /// </summary>
        /// <param name="newColor"></param>
        public void ChangeFavoriteColor()
        {
            // Change the favorite color to "White"
            FavoriteColor = "White";
        }

        /// <summary>
        /// Get the persons ag in 10 years
        /// </summary>
        public void GetAgeInTenYears()
        {
            int newAgeInTenYears = Age + 10;
            Console.WriteLine($"{FullName} in ten years is: " + newAgeInTenYears);
        }

        /// <summary>
        /// Displays the Person Object information as a list
        /// </summary>
        public override string ToString()
        {
            string displayPersonInfo =
                string.Format($"Person ID: {PersonID}") + "\n" +
                string.Format($"First Name: {FirstName}") + "\n" +
                string.Format($"Last Name: {LastName}") + "\n" +
                string.Format($"Favorite Color: {FavoriteColor}") + "\n" +
                string.Format($"Age: {Age}") + "\n" +
                string.Format($"Is Working: {IsWorking}");

            return displayPersonInfo;
        }

    }
}
