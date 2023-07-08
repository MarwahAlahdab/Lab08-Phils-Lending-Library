using System.Reflection;
using Phils_Lending_Library;
using static System.Formats.Asn1.AsnWriter;

namespace LibraryTests;

public class UnitTest1
{



    //    Add a Book to your Library
    [Fact]
    public void Add_AddBookToLibrary()
    {
        // Arrange
        Library library = new Library();
        
        Book book = new Book("Title ", "Marwa", "Alahdab", 200);

        // Act
        library.Add(book.Title, book.FirstName, book.LastName, book.NumberOfPages);

        // Assert
      
        Assert.Equal(1, library.Count);
    }




    //Borrowing an existing title returns the Book and remove it
    //Hint: Assert.DoesNotContain(book, library)
    //Hint: Count should decrease



    [Fact]
    public void Borrow_ExistBook_ReturnsBookAndRemovesFromLibrary()
    {
        // Arrange
        
        Library library = new Library();
        Book book = new Book("Title", "Marwa", "Alahdab", 200);
        library.Add(book.Title, book.FirstName, book.LastName, book.NumberOfPages);

        // Act
        Book borrowedBook = library.Borrow(book.Title);

        // Assert
        Assert.DoesNotContain(book, library);
        Assert.Equal(0, library.Count);
    }


    //Borrowing a missing title returns null


    [Fact]
    public void Borrow_MissingBook_ReturnsNull()
    {
        Library library = new Library();

        
        Book borrowedBook = library.Borrow("MissingTitle");


        Assert.Null(borrowedBook);
    }



    //A returned book is once again in the Library
    //Hint: Assert.Contains(book, library)
    //Hint: Count should increase

    [Fact]
    public void Return_ReturnesBook()
    {
        // Arrange
        Library library = new Library();
        Book book = new Book("Title", "M", "A", 100);

        // Act
        library.Return(book);

        // Assert
        Assert.Contains(book, library);
        Assert.Equal(1, library.Count);
    }



//    Pack and Unpack your Backpack
//Hint: Backpack can store anything so it may be easier to test with string or int instead of Book`

    [Fact]
    public void Pack_AddsItemToBackpack()
    {
        Backpack<string> backpack = new Backpack<string>();

        backpack.Pack("Item");

        Assert.Contains("Item", backpack);
    }

    [Fact]
    public void Unpack_RemovesItemFromBackpack()
    {
        Backpack<int> backpack = new Backpack<int>();
        backpack.Pack(42);

       
        int unpackedItem = backpack.Unpack(0); //index

        Assert.Equal(42, unpackedItem);
    }


}
