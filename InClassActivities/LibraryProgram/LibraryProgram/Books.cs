using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram
{
    internal class Books : LibraryItem, IBorrowable
    {
        public int NumberOfPages { get; set; }
        public bool IsAvailable { get; set; }
        public string? Borrower { get; set; }


        public override double CalculateLateFee(int daysLate)
        {
            // if the book is late, calculate the late fee and display it
            double fee = daysLate * 0.25;
            return daysLate * 0.25;
        }

        public void BorrowItem(string borrower)
        {
            // if it is, set the borrower and set the book to unavailable
            // if it is not, display a message that the book is not available
            if (IsAvailable)
            {
                Borrower = borrower;
                IsAvailable = false;
                Console.WriteLine($"The {Title} has been borrowed by {borrower}.");
            }
            else
            {
                Console.WriteLine($"The {Title} is borrowed already by {borrower}.");
            }
        }

        public void ReturnItem(int daysLate)
        {
            // Return the book if it is available 
            if (IsAvailable)
            {
                if (daysLate == 0)
                {
                    // display message that the book is returned 
                    Console.WriteLine($"The {Title} is already returned by {Borrower}.");

                    // set the borrower to null and set the book to available
                    // Borrower is null because the book is not borrowed by anyone
                    Borrower = null;
                    IsAvailable = true;
                }
                
            }
            else if (daysLate > 0)
            {
                // if the book is late, calculate the late fee and display it
                double lateFee = CalculateLateFee(daysLate);
                Console.WriteLine($"The {Title} has been returned by {Borrower} with a late fee: ${lateFee}.");

                // set the borrower to null and set the book to available
                // Borrower is null because the book is not borrowed by anyone
                Borrower = null;
                IsAvailable = true;
            }
            

        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of pages: {NumberOfPages}");

            string displayAvailability = IsAvailable == true ? "Available" : "Borrowed by: " + Borrower;
            Console.WriteLine($"{displayAvailability}");

        }
    }
}
