using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_2
{
    /// <summary>
    /// Base class representing a book
    /// </summary>
    internal class Book
    {
        // Properties of book
        public string BookTitle { get; set; }
        public int BookId { get; set; }
        public string BookAuthor { get; set; }
        public int BookPublicationYear { get; set; }
        public bool IsAvailable { get; set; } = true;

        // Parameterized constructor for initializing the book properties
        public Book(string bookTitle, int bookId, string bookAuthor, int bookPublicationYear)
        {
            BookTitle = bookTitle;
            BookId = bookId;
            BookAuthor = bookAuthor;
            BookPublicationYear = bookPublicationYear;
        }
    }

    /// <summary>
    /// FictionBook class extends the Book class
    /// </summary>
    internal class FictionBook : Book
    {
        // Additional property for fiction books
        public string MainCharacter { get; set; }

        // Parameterized constructor for initializing fiction book properties
        public FictionBook(string bookTitle, int bookId, string bookAuthor, int bookPublicationYear, string mainCharacter)
        : base(bookTitle, bookId, bookAuthor, bookPublicationYear)
        {
            MainCharacter = mainCharacter;
        }
    }

    /// <summary>
    /// NonFictionBook class extends the Book class
    /// </summary>
    internal class NonFictionBook : Book
    {
        // Additional property for non-fiction books
        public string Subject { get; set; }

        // Parameterized constructor for initializing non-fiction book properties
        public NonFictionBook(string bookTitle, int bookId, string bookAuthor, int bookPublicationYear, string subject)
        : base(bookTitle, bookId, bookAuthor, bookPublicationYear)
        {
            Subject = subject;
        }
    }
}
