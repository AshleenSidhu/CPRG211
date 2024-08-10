using LinkedList;
using System.Collections.Generic;

namespace LinkedListTest
{
	[TestFixture]
	public class Tests
	{
		public LinkedList.LinkedList _linkedList;

		[SetUp]
		public void Setup()
		{
			_linkedList = new LinkedList.LinkedList();
		}

		[TestCase]
		public void AddingFirst()
		{
			// Arrange
			string name = "Joe Blow";
			string name2 = "Joe Schmoe";

			// Act
			_linkedList.AddFirst(name);
			_linkedList.AddFirst(name2);
			string expected = name2;

			// Assert
			Assert.AreEqual(name2, _linkedList.Head.Value);
			Assert.AreEqual(2, _linkedList.Count);
		}

		[Test]
		public void AddingLast()
		{
			// Arrange
			string name = "Joe Blow";
			string name2 = "Joe Schmoe";
			string name3 = "John Smith";
			string name4 = "Jane Doe";

			// Act
			_linkedList.AddFirst(name);
			_linkedList.AddFirst(name2);
			_linkedList.AddFirst(name3);
			_linkedList.AddFirst(name4);

			// Assert
			Assert.AreEqual(name, _linkedList.Tail.Value);
			Assert.AreEqual(4, _linkedList.Count);
		}

		[Test]
		public void RemovingFirstNode()
		{
			// Arrange
			string name = "Joe Blow";
			string name2 = "Joe Schmoe";
			string name3 = "John Smith";
			string name4 = "Jane Doe";

			// Act
			_linkedList.AddFirst(name);
			_linkedList.AddFirst(name2);
			_linkedList.AddFirst(name3);
			_linkedList.AddFirst(name4);
			_linkedList.RemoveFirst();

			// Assert
			Assert.AreEqual(name, _linkedList.Tail.Value);
			Assert.AreEqual(3, _linkedList.Count);
		}

		[Test]
		public void RemovingLastNode()
		{
			// Arrange
			string name = "Joe Blow";
			string name2 = "Joe Schmoe";
			string name3 = "John Smith";

			// Act
			_linkedList.AddLast(name);
			_linkedList.AddLast(name2);
			_linkedList.AddLast(name3);

			_linkedList.RemoveLast();

			// Assert
			Assert.AreEqual(name2, _linkedList.Tail.Value);
			Assert.AreEqual(3, _linkedList.Count);
		}


			[Test]
		public void RetrievingGivenNode()
		{
			// Arrange
			string name = "Joe Blow";
			string name2 = "Joe Schmoe";

			// Act
			_linkedList.AddLast(name);
			_linkedList.AddLast(name2);

			var value = _linkedList.GetValue(1);

			// Assert
			Assert.AreEqual(name2, value);
			Assert.AreEqual(3, _linkedList.Count);
		}

		[Test]
		public void DetermineListSize()
		{
			// Arrange
			_linkedList.AddFirst("Joe Blow");
			_linkedList.AddFirst("Joe Schmoe");
			_linkedList.AddFirst("John Smith");
			_linkedList.AddFirst("Jane Doe");
			_linkedList.AddFirst("Bob Bobberson");
			_linkedList.AddFirst("Sam Sammerson");
			_linkedList.AddFirst("Dave Daverson");

			// Act
			var size = _linkedList.Count;

			// Assert
			Assert.AreEqual(7, size);
		}


		// Additional tests to test edge cases

		[Test]
		public void RemoveFirst_isEmpty()
		{
			// Arrange 
			_linkedList.RemoveFirst();

			// Assert
			Assert.That(_linkedList.Head, Is.Null); // Check if the head is null
			Assert.That(_linkedList.Count, Is.EqualTo(0));
		}

		[Test]
		public void RemoveLast_isEmpty()
		{
			// Act
			_linkedList.RemoveLast();

			// Assert
			Assert.That(_linkedList.Head, Is.Null); // Check if the head is null
			Assert.That(_linkedList.Count, Is.EqualTo(0));
		}

		[Test] // Test to see if the list is empty
		public void GetValue_HandleEmptyList()
		{
			Assert.That(_linkedList.GetValue(0), Is.EqualTo("Index is out of range."));
		}
	}
}