using System.Diagnostics.Metrics;
using System.Globalization;

namespace LinkedListClassActivity
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Linked List Tests:");

			LinkedList myList = new LinkedList();

			myList.AddFirst("Book1");
			myList.AddFirst("Book2");
			myList.AddFirst("Book3");
			myList.AddFirst("Book4");
			myList.AddFirst("Book5");

			Console.WriteLine("\nList books:");
			Console.WriteLine(myList.Search("Book2"));
			myList.PrintAllNodes();

			Console.WriteLine("\nTotal elements in the list:");
			Console.WriteLine(myList.Count());

			myList.AppearenceTimes();


			//Console.WriteLine("Enter a book to search for:");
			//string search = Console.ReadLine();

			//if (search != null)
			//{
			//	Console.WriteLine(myList.Search(search));
			//	if (myList.Search(search) != null)
			//	{
			//		Console.WriteLine("Found");
			//	}
			//	else
			//	{
			//		Console.WriteLine("Not Found");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("Invalid input");
			//}

			//display total amount of elements in the list


			//myList.AddFirst("Class Activity");
			//myList.AddFirst("OOP2");

			//Console.WriteLine("\nAdd First Result:");
			//myList.PrintAllNodes();

			//myList.AddLast("last element 1");
			//Console.WriteLine("\nAdd LAST Result:");
			//myList.PrintAllNodes();


			//myList.RemoveAt(1);

			//Console.WriteLine("\nRemove at index 1");
			//myList.PrintAllNodes();

			//Console.WriteLine("\nRemove Last:");
			//myList.RemoveLast();
			//myList.PrintAllNodes();
		}
	}
}
