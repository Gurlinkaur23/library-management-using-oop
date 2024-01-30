using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_2
{
    /// <summary>
    /// Librarian class extends the User class
    /// </summary>
    internal class Librarian : User, IManageable
    {
        // Additional property for librarians
        public double Salary { get; set; }

        // Parameterized constructor for initializing librarian properties
        public Librarian(string firstName, string lastName, int id, double salary)
        : base(firstName, lastName, id)
        {
            Salary = salary;
        }

        /// <summary>
        /// This method adds a book to the library
        /// </summary>
        /// <param name="book"></param>
        public void AddBookToLibrary(Book book)
        {
            // Implementation for adding a book to the library

            Console.WriteLine($"'{book.BookTitle}' book has been added to the library.");
        }

        /// <summary>
        /// This method removes a book from the library
        /// </summary>
        /// <param name="book"></param>
        public void RemoveBookFromLibrary(Book book)
        {
            // Implementation for removing a book from the library

            Console.WriteLine($"'{book.BookTitle}' book has been removed from the library.");
        }

        /// <summary>
        /// This method adds a member to the library
        /// </summary>
        /// <param name="member"></param>
        public void AddMember(Member member)
        {
            // Implementation to add someone as a member of library

            Console.WriteLine($"'{member.FirstName} {member.LastName}' has become a member of the library.");
        }
    }
}
