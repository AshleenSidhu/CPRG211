using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram
{
    // Abstract LibraryItem class
    public abstract class LibraryItem
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"\nTitle: {Title}, Author: {Author}, ISBN: {ISBN}");
        }

        public abstract double CalculateLateFee(int daysLate);
    }
}
