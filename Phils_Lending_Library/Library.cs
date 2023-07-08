using System;
using System.Collections;
using System.Drawing;

namespace Phils_Lending_Library
{
    public class Library: ILibrary
    {
        //Since books need to be borrowed by Title, use a private Dictionary<string, Book> for storage.

        private Dictionary<string, Book> books;

        public Library()
        {
            books = new Dictionary<string, Book>();
        }



        public int Count => books.Count;




        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book(title, firstName, lastName, numberOfPages);
            books.Add(title, book);
        }


        public Book Borrow(string title)
        {

            foreach(KeyValuePair<string, Book> book in books)
            {
                if(book.Key == title)
                {
                    books.Remove(book.Key);
                    return book.Value;
                }
            }

            return null;

        }


        public void Return(Book book)
        {
           
            books[book.Title] = book;
            // add the value "book" at the key "book.Title"

        }

        public IEnumerator<Book> GetEnumerator()      //enables iteration over a collection of Book objects

        {
            return books.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

