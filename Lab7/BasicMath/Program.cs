/*
 * The BasicMath class contains four methods: Add, Subtract, Divide, and Multiply.
 * Name: Ashleen Sidhu
 * Date: 2024-07-28
 */

using System.Transactions;

namespace BasicMath
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BasicMath basicMath = new BasicMath();

			Console.WriteLine($"Addition: {basicMath.Add(5, 5)}");
			Console.WriteLine($"Subtraction: {basicMath.Subtract(20, 6)}");
			Console.WriteLine($"Division: {basicMath.Divide(19, 2)}");
			Console.WriteLine($"Multiplication: {basicMath.Multiply(7, 5)}");
		}
	}
}
