namespace LibraryProgram
{
    internal class Program
    {
        static List<LibraryItem> libraryItems = new List<LibraryItem>();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add DVD");
                Console.WriteLine("3. Borrow Item");
                Console.WriteLine("4. Return Item");
                Console.WriteLine("5. Display All Items");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        AddDVD();
                        break;
                    case 3:
                        BorrowItem();
                        break;
                    case 4:
                        ReturnItem();
                        break;
                    case 5:
                        DisplayAllItems();
                        break;
                    case 6:
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void BorrowItem()
        {
            // Check if the item is a book or a DVD
            // If it is a book, borrow the book
            // If it is a DVD, borrow the DVD
            // If it is neither, display a message that the item is not found
            Console.Write("\nEnter ISBN of the item you want to borrow: ");
            string isbn = Console.ReadLine();

            Console.Write("Enter borrower name: ");
            string borrowerName = Console.ReadLine();

            foreach (LibraryItem item in libraryItems)
            {
                if (item.ISBN == isbn)
                {
                    if (item is Books)
                    {
                        Books book = (Books)item;
                        book.BorrowItem(borrowerName);
                    }
                    else if (item is DVD)
                    {
                        DVD dvd = (DVD)item;
                        dvd.BorrowItem(borrowerName);
                    }
                    
                }
            }
            
        }

        static void ReturnItem()
        {
            // Check if the item is a book or a DVD
            // If it is a book, return the book
            // If it is a DVD, return the DVD
            // If it is neither, display a message that the item is not found
            Console.Write("\nEnter ISBN of the item to return: ");
            string isbn = Console.ReadLine();

            Console.Write("Enter number of days late: ");
            int daysLate = int.Parse(Console.ReadLine());

            foreach (LibraryItem item in libraryItems)
            {
                if (item.ISBN == isbn)
                {
                    if (item is Books)
                    {
                        Books book = (Books)item;
                        book.ReturnItem(daysLate);
                    }
                    else if (item is DVD)
                    {
                        DVD dvd = (DVD)item;
                        dvd.ReturnItem(daysLate);
                    }
                }
            }
            

        }

        static void AddBook()
        {
            Books book = new Books();
            // Create a new book object
            Console.Write("\nEnter the title: ");
            book.Title = Console.ReadLine();

            Console.Write("Enter the author: ");
            book.Author = Console.ReadLine();

            Console.Write("Enter the ISBN: ");
            book.ISBN = Console.ReadLine();

            Console.Write("Enter number of pages: ");
            book.NumberOfPages = int.Parse(Console.ReadLine());

            // Set the book to available
            book.IsAvailable = true;

            // Add the book to the library
            libraryItems.Add(book);
            Console.WriteLine("Book added successfully.");
        }
        static void AddDVD()
        {
            // Add a book to the library
            // Create a new book object
            DVD dvd = new DVD();
            Console.Write("\nEnter the title: ");
            dvd.Title = Console.ReadLine();

            Console.Write("Enter the author: ");
            dvd.Author = Console.ReadLine();

            Console.Write("Enter the ISBN: ");
            dvd.ISBN = Console.ReadLine();

            Console.Write("Enter duration (in minutes): ");
            dvd.Duration = int.Parse(Console.ReadLine());

            // Set the book to available
            dvd.IsAvailable = true;

            // Add the book to the library
            libraryItems.Add(dvd);
            Console.WriteLine("DVD added successfully.");
        }

        static void DisplayAllItems()
        {
            // Display all items in the library
            foreach (LibraryItem item in libraryItems)
            {
                item.DisplayInfo();
            }
        }
    }
}
