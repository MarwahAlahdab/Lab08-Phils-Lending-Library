using System;
namespace Phils_Lending_Library
{
    public class Book
    {

        public string Title { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int NumberOfPages { get; }

        public Book(string title, string firstName, string lastName, int numberOfPages)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
            NumberOfPages = numberOfPages;
        }
    }
}

