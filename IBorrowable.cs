using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_2
{
    /// <summary>
    /// Interface for borrowable functionality
    /// </summary>
    internal interface IBorrowable
    {
        void BorrowBookFromLibrary(Book book);
    }
}
