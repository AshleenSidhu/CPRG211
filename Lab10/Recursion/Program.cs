///CPRG211
///Recursion Assignment
///Author: Ashleen Sidhu
///Date: 2024-08-10
namespace Recursion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition");

            //Prompt user to enter two numbers
            Console.WriteLine("Enter number n: ");
            int numberN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number m: ");
            int numberM = Convert.ToInt32(Console.ReadLine());

            //Display the sum of all the numbers from n to m
            Console.WriteLine(Sum(numberN, numberM));


            
            Console.WriteLine("\nDivision");

            //Prompt user to enter a number
            Console.WriteLine("Enter your number:");
            int number = Convert.ToInt32(Console.ReadLine());

            //Display the total number of divisions
            Console.WriteLine($"Total number of divisions: {CountDividedBy2(number)}");

        }

        /// <summary>
        /// method that calculates the sum of all the numbers from n to m, recursively.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int Sum(int n, int m)
        {
            if (n == m)
            {
                return n;
            }
            else
            {
                return n + Sum(n + 1, m);
            }
        }

        /// <summary>
        /// method that that prints out how many times a number entered by the user can be evenly divided by 2.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountDividedBy2(int n)
        {
            if (n % 2 != 0)
            {
                return 0;
            }
            else
            {
                return 1 + CountDividedBy2(n / 2);
            }
        }

    }
}
