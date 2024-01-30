using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_2
{
    /// <summary>
    /// This class represents the transaction of borrowing a book
    /// </summary>
    internal class Transaction
    {
        // Implementation to borrow a book
        public static void BorrowBook(Book book, Member member)
        {
            // Check if the book is available to borrow
            if (book.IsAvailable)
            {
                Console.WriteLine($"'{book.BookTitle}' book has been borrowed by {member.FirstName} {member.LastName}");

                // Update the availability of the book
                book.IsAvailable = false;
            }
            else
            {
                Console.WriteLine($"'{book.BookTitle}' book is not available for borrowing at the moment.");
            }
        }
    }
}
