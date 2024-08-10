using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
	public class LinkedList
	{
		public Node Head { get; set; }
		public Node Tail { get; set; }
		public int Count { get; set; }

		public LinkedList()
		{
			Head = null;
			Tail = null;
			Count = 0;
		}

		// Add a node at the beginning of the list.
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

			Count++;
		}

		// Add a node at the end of the list.
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
			Count++;
		}

		// Prints all the nodes in the list.
		public void PrintAllNodes()
		{
			Node current = Head;
			while (current != null)
			{
				Console.WriteLine(current.Value);
				current = current.Next;
			}
		}

		// Remove the first node.
		public void RemoveFirst()
		{
			if (Head != null)
			{
				if (Head == null)
				{
					Tail = null;
				}
				Count--;
			}
			else
			{
				Console.WriteLine("List is empty");
			}
		}

		// Remove the last node.
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
			// Decrease count of nodes.
			Count--;

		}

		// Retrieves the value of the node at the given index.
		public string GetValue(int index)
		{
			if (index >= Count || index < 1)
			{
				//throw new IndexOutOfRangeException("Index is out of range.");
				return "Index is out of range.";
			}

			Node current = Head;
			for (int i = 0; i < index; i++)
			{
				current = current.Next;
			}
			return current.Value;
		}

	}
}
