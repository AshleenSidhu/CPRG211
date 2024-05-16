using System.Transactions;
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Lab0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ask the user to enter a low number
            Console.Write("Please Enter a low number: ");
            int lowNumber = Convert.ToInt32(Console.ReadLine());

            // Loops until user enters a positive integer
            while (lowNumber <= 0)
            {
                Console.Write("Incorrect. Please enter a positive low number: ");
                lowNumber = Convert.ToInt32(Console.ReadLine());
            }

            // Ask user to enter a high number
            Console.Write("Please Enter a high number: ");
            int highNumber = Convert.ToInt32(Console.ReadLine());

            // Loops until user enters a number that is higher than the low number
            while (highNumber <= lowNumber) 
            {
                Console.Write("Incorrect. Please enter a number higher than the low number: ");
                highNumber = Convert.ToInt32(Console.ReadLine());
            }

            // Display the difference between high and low number the user entered
            Console.WriteLine(" ");
            Console.WriteLine("--------Calculate Difference--------");
            Console.WriteLine(highNumber + " - " + lowNumber + " = " + (highNumber - lowNumber));

            // Task 3: array that holds all the numbers between low and high number the user inputed 
            int[] highLowNumberArray = new int[highNumber - lowNumber + 1];
            
            // Fills the array with the low to high numbers 
            for (int i = 0; i < highLowNumberArray.Length; i++)
            {
                highLowNumberArray[i] = lowNumber + i;
            }

            // Creates a 'numbers.txt' file
            string numbersFile = "numbers.txt";

            // Sorts the array in acending order and then reverses the order
            Array.Sort(highLowNumberArray);
            Array.Reverse(highLowNumberArray);

            //Console.WriteLine(string.Join(" ", highLowNumberArray));
            File.WriteAllText("numbers.txt", string.Join(", ", highLowNumberArray));

            // Calls on the getUserInput method to read the contents of the file and total sum of numbers in the file
            GetValidUserInput(numbersFile, highLowNumberArray);

            //Additional tasks: using double data type intead of string and list instead of array

            List<double> highLowNumberList = new List<double>();

            // Fills the list with the low to high numbers 
            for (double i = lowNumber; i <= highNumber; i++)
            {
                highLowNumberList.Add(i);
            }

            Console.WriteLine("\n---High to low Numbers from List----");

            // Sorts the list in descending order and prints the list
            highLowNumberList.Reverse();
            Console.WriteLine(string.Join(", ", highLowNumberList));

            Console.WriteLine("\n-----------Prime Numbers-----------");

            // Sorts the list in ascending order and prints the prime numbers
            highLowNumberList.Sort();
            foreach (double primeNumber in highLowNumberList)
            {
                if (FindPrimeNumber(primeNumber))
                {
                    Console.Write(primeNumber + ", ");
                }
                
            }
            
            Console.ReadKey();

        }

        static void GetValidUserInput(string numberFileName, int[] highLowNumberArray)
        {
            Console.WriteLine("\n------------File Output-------------");

            // Read the content of "numbers.txt" and print it to the console
            string fileContent = File.ReadAllText(numberFileName);
            Console.WriteLine(fileContent);

            Console.WriteLine("\n-------------Number Sum-------------");

            // Initialize a variable to be 0
            int sumNumbers = 0;

            // For each number in the array that is in the file, add the numbers to the variable sumNumbers
            foreach (int number in highLowNumberArray)
            {
                sumNumbers += number;
            }
            Console.WriteLine(sumNumbers);
        }

        static bool FindPrimeNumber(double primeNumber)
        {
            // The number is less than or equal to 1 then is is not prime
            // The number is 2 then it is prime
            // The number is not 2 and is even then it is not prime
            if (primeNumber <= 1) 
            {  
                return false; 
            }
            else if (primeNumber == 2)
            {
                return true;
            }
            else if (primeNumber % 2 == 0)
            {
                return false;
            }

            // Checks if 3 is less than or equal to the square root of the prime number
            // If the prime number is divisible by 3 then it is not prime
            // Increments by 2 to check if the prime number is divisible by odd numbers
            for (int i = 3; i <= Math.Sqrt(primeNumber); i+= 2)
            {
                // If the prime number is divisible by i then it is not prime
                if (primeNumber % i == 0)
                {
                    return false;
                }
            }

            // The number is prime then returns true
            return true;

        }

    }

}
