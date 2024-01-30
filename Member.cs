using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_2
{
    /// <summary>
    /// Member class extends the User class
    /// </summary>
    internal class Member : User, IBorrowable
    {
        // Parameterized constructor for initializing member properties
        public Member(string firstName, string lastName, int id)
        : base(firstName, lastName, id)
        {
        }

        /// <summary>
        /// This method borrows a book from the library
        /// </summary>
        /// <param name="book"></param>
        public void BorrowBookFromLibrary(Book book)
        {
            // Implementation for borrowing the book by calling the static method from Transaction class
            Transaction.BorrowBook(book, this);
        }

        /// <summary>
        /// This method returns a book to the library
        /// </summary>
        /// <param name="book"></param>
        public void ReturnBookToLibrary(Book book)
        {
            // Implementation for returning the book
            Console.WriteLine($"'{book.BookTitle}' has been returned to the library.");
        }
    }

}
