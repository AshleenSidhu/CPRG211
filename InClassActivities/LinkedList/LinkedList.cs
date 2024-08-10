using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListClassActivity
{
	internal class LinkedList
	{
		public Node Head { get; set; }
		public Node Tail { get; set; }
		public int counter { get; set; }

		public LinkedList()
		{
			Head = null;
			Tail = null;
			counter = 0;
		}

		public void AddFirst(string data)
		{
			Node newNode = new Node(data);
			if (Head == null)
			{
				Head = newNode;
				Tail = newNode;

			}

			else
			{
				newNode.Next = Head;
				Head = newNode;

			}

			counter++;
		}

		public void AddLast(string data)
		{
			Node newNode = new Node(data);
			if (Head == null)
			{
				AddFirst(data);
			}
			else
			{
				Tail.Next = newNode;
				Tail = newNode;
			}
			counter++;
		}

		public void PrintAllNodes()
		{
			Node current = Head;
			while (current != null)
			{
				Console.WriteLine(current.Value);
				current = current.Next;
			}
		}

		public void RemoveFirst()
		{
			if (Head != null)
			{
				if (Head == null)
				{
					Tail = null;
				}
				counter--;
			}
			else
			{
				Console.WriteLine("List is empty");
			}
		}

		public void RemoveLast()
		{
			if (Head == null) // Check if the list is empty.
			{
				Console.WriteLine("List is already empty.");
				return;
			}
			if (Head.Next == null) // Check if there is only one node in the list.
			{
				Head = null; // Make the list empty.
				Tail = null;
			}
			else
			{
				Node current = Head;
				while (current.Next.Next != null) // Traverse until the second-last node.
				{
					current = current.Next;
				}
				current.Next = null; // Remove the last node by setting the second-last node's next to null.
				Tail = current; // Update the Tail to the new last node.
			}
			counter--; // Decrease count of nodes.

		}

		public void RemoveAt(int index)
		{
			if (index < 0 || index >= counter) // Check if the position is out of bounds.
			{
				Console.WriteLine($"Invalid position: {index}");
				return;
			}
			if (index == 0) // If position is 0, remove the first node.
			{
				RemoveFirst();
				return;
			}
			if (index == counter - 1) // If position is the last index, remove the last node.
			{
				RemoveLast();
				return;
			}
			// Find the node just before the node to be removed.
			Node current = Head;
			for (int i = 0; i < index - 1; i++)
			{
				current = current.Next;
			}
			current.Next = current.Next.Next; // Skip the node to be removed.
			counter--;
		}

		public void InsertAfter(string target, string newData)
		{
			Node current = Head;

			while (current != null)
			{
				if (current.Value.Equals(newData))
				{
					Node newNode = new Node(newData);

					newNode.Next = current.Next;
					current.Next = newNode;

					if (current == Tail)
					{
						Tail = newNode;
					}

					counter++;
					return;
				}
				current = current.Next;
			}
		}

		public void InsertBefore(string target, string newData)
		{
			Node current = Head;
			while (current != null)
			{
				if (current.Next.Value.Equals(target))
				{
					Node newNode = new Node(newData);
					newNode.Next = current.Next;
					current.Next = newNode;
					if (current == Head)
					{
						Head = newNode;
					}
					counter++;
					return;
				}
				current = current.Next;
			}

		}

		//search for a node
		public Node Search(string value)
		{
			Node current = Head;
			while (current != null)
			{
				if (current.Value.Equals(value))
				{
					return current;

				}
				current = current.Next;
			}
			return null;
		}

		public void AppearenceTimes()
					{
			Node current = Head;
			int count = 0;
			while (current != null)
			{
				count++;
				current = current.Next;
			}
			Console.WriteLine("The number of times the book appears in the list is: " + count);
		}

	//count the number of nodes
		public int Count()
		{
			return counter;
		}
	}
}
