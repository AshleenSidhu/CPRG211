using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram
{
    // Interface IBorrowable
    public interface IBorrowable
    {
        void BorrowItem(string borrower);
        void ReturnItem(int daysLate);
    }

}
