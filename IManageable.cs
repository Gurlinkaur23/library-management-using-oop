using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_2
{
    internal interface IManageable
    {
        /// <summary>
        /// Interface for manageable functionality
        /// </summary>
        /// <param name="book"></param>
        void AddBookToLibrary(Book book);
        void RemoveBookFromLibrary(Book book);
        void AddMember(Member member);
    }
}
