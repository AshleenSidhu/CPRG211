using LibraryManagementSystem;

namespace LibraryTest
{
    [TestFixture]
    public class Tests
    {
        private Library _library; // Instance of Library class

        [SetUp] // Method executed before each test method
        public void Setup() // Setup method to initialize Library object
        {
            _library = new Library(); // Creating an instance of Library
        }

        [Test] // Attribute marking this method as a test
        public void AddBook_WhenCalled_AddsBookToLibrary()
        {
            _library.AddBook("Wonder 2");
            Assert.IsTrue(_library.IsBookAvailable("Wonder 2"));
        }

        [Test] // Attribute marking this method as a test
        public void AddBook_NullOrEmptyBook_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _library.AddBook(null));
            Assert.Throws<ArgumentException>(() => _library.AddBook(string.Empty));
        }

        [Test] // Attribute marking this method as a test
        public void RemoveBook_WhenCalled_RemovesBookFromLibrary()
        {
            _library.AddBook("Harry Potter");
            _library.RemoveBook("Harry Potter");
            Assert.IsFalse(_library.IsBookAvailable("Harry Potter"));
        }

        [Test] // Attribute marking this method as a test
        public void RemoveBook_BookNotInLibrary_ReturnsFalse()
        {
            bool result = _library.RemoveBook("Book does not exist");
            Assert.IsFalse(result);
        }

        [Test] // Attribute marking this method as a test
        public void IsBookAvailable_WhenCalled_ReturnsCorrectAvailability()
        {
            _library.AddBook("Wonder 2");
            Assert.IsTrue(_library.IsBookAvailable("Wonder 2"));
            Assert.IsFalse(_library.IsBookAvailable("Book is Unavailable"));
        }

        [Test] // Attribute marking this method as a test
        public void GetTotalBooks_WhenCalled_ReturnsCorrectCount()
        {
            _library.AddBook("Wonder");
            _library.AddBook("Romeo and Juliet");
            _library.AddBook("The Great Gatsby");

            int totalBooks = _library.GetTotalBooks();

        }

    }
}