using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creating objects from different classes
                FictionBook fictionBook = new FictionBook("Harry Potter", 123, "J. K. Rowling", 1990, "Harry Potter");

                NonFictionBook nonFictionBook = new NonFictionBook("The Power of your Subconscious Mind", 456, 
                    "Joseph Murphy", 2015, "Psychology");

                Member member = new Member("Phoebe", "Buffay", 1);

                Librarian librarian = new Librarian("Monica", "Geller", 2, 10000);


                // Displaying the console
                Console.WriteLine(" * - * - * - * - Library Management System - * - * - * - *");
                Console.WriteLine();

                // Adding books to library as a librarian
                librarian.AddBookToLibrary(fictionBook);
                librarian.AddBookToLibrary(nonFictionBook);
                Console.WriteLine();

                // Displaying books in the library
                Console.WriteLine("The books currently in the library are:");
                Console.WriteLine($"Title: {fictionBook.BookTitle}, Author: {fictionBook.BookAuthor}, Book Id: " +
                    $"{fictionBook.BookId}, Publication Year: {fictionBook.BookPublicationYear}");
                Console.WriteLine($"Title: {nonFictionBook.BookTitle}, Author: {nonFictionBook.BookAuthor}, Book Id: " +
                    $"{nonFictionBook.BookId}, Publication Year: {nonFictionBook.BookPublicationYear}");
                Console.WriteLine();

                // Borrow books from the library as a member
                member.BorrowBookFromLibrary(fictionBook);
                Console.WriteLine();

                // Remove books from the library as a librarian
                librarian.RemoveBookFromLibrary(nonFictionBook);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
