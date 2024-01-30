using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_2
{
    /// <summary>
    /// Base class representing a user
    /// </summary>
    internal class User
    {
        // Properties of a user
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        // Parameterized constructor for initializing user properties
        public User(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
    }
}
