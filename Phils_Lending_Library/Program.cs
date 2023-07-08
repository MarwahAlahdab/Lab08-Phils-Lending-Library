using Phils_Lending_Library;

internal class Program
{
    private static void Main(string[] args)
    {
        Library library = new Library();

        library.Add("Book1", "M", "A", 200);
        library.Add("book2", "A", "N", 350);

        Console.WriteLine($"Number of books we have : {library.Count}");
        Console.WriteLine("Existing books :");
        foreach (Book book in library)
        {
            Console.WriteLine(book.Title);
        }


        // Borrow book
        string titleToBorrow = "book3";
        Book borrowedBook = library.Borrow(titleToBorrow);
        if (borrowedBook != null)

            Console.WriteLine($"Borrowed book: {borrowedBook.Title}");

        else
        {
            Console.WriteLine($"Book '{titleToBorrow}' is not available !");
        }


        // Creating backpack
        Backpack<string> backpack = new Backpack<string>();
        //pack
        backpack.Pack("Item1");
        backpack.Pack("Item2");
    

        Console.WriteLine("All Items:");
        foreach (string item in backpack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Unpack 
        int index = 1;
        string unpackedItem = backpack.Unpack(index);
        Console.WriteLine($"Unpacked item: {unpackedItem}");
        Console.WriteLine("All Items:");
        foreach (string item in backpack)
        {
            Console.WriteLine(item);
        }





    }
}